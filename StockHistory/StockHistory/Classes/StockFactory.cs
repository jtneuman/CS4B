using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace StockHistory.Classes
{
    class StockFactory
    {

        #region Constants
        private const string urlTemplateYahoo =
            "http://ichart.finance.yahoo.com/table.csv?s=" +
            "{0}&d={1}&e={2}&f={3}&g=d&a={1}&b={2}&c={4}&ignore=.csv";

        private const string urlTemplateNasdaq = "http://charting.nasdaq.com/ext/charts.dll?2-1-14-0-0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0|0,0,0,0,0-5120-03NA000000{0}-&SF:4|5-WD=539-HT=395--XXCL-";
        #endregion

        #region Properties
        public static bool IsInternetAvailable { get {
                return NetworkInterface.GetIsNetworkAvailable(); } }
        #endregion

        #region Constructor
        public StockFactory()
        {
            /*  When an async requests is canceled exceptions are thrown. 
                These exceptions must be observed to avoid exceptions 
                being thrown by the Garbage Collection during clean-up
                of the Task objects.
            */
            TaskScheduler.UnobservedTaskException += new EventHandler<UnobservedTaskExceptionEventArgs>(
                TaskUnobservedException_Handler);
        }
        #endregion

        #region Methods
        /// <summary>
        /// ParsePrices from the Response stream containing the stock data
        /// </summary>
        /// <param name="response"></param>
        /// <param name="separators"></param>
        /// <param name="dataIndex"></param>
        /// <returns></returns>
        // Note example code used "Response" as paramenter name?
        private static List<decimal> ParsePrices(WebResponse response,
            char[] separators, int dataIndex)
        {
            // Open data stream and parse the data
            try
            {
                List<decimal> prices = new List<decimal>();

                using (Stream WebStream = response.GetResponseStream())
                {
                    using (StreamReader Reader = new StreamReader(WebStream))
                    {
                        // Read the data stream
                        while (!Reader.EndOfStream)
                        {
                            string record = Reader.ReadLine();
                            string[] tokens = record.Split(separators);
                            DateTime date;
                            decimal data;

                            // Add prices that have valid dates
                            // Use the culture to ensure that the decimal parse works in cultures where a comma is used as a separator.

                            if (DateTime.TryParse(tokens[0], out date))
                                if (Decimal.TryParse(tokens[dataIndex],
                                    NumberStyles.AllowDecimalPoint,
                                    new CultureInfo("en-US"), out data))
                                    prices.Add(data);
                        }
                    }
                }
                return prices;
            }
            finally
            {
                try
                {
                    // Close the response stream before the data is returned
                    response.Close();
                }
                catch
                {
                }
            }
            
        }// End Parse Prices method

        /// <summary>
        /// Tries to download stock data asynchronously from Yahoo or Nasdaq.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="site"></param>
        /// <param name="dataSource"></param>
        /// <param name="symbol"></param>
        /// <param name="separators"></param>
        /// <param name="dataIndex"></param>
        /// <param name="yearsOfHistory"></param>
        /// <param name="request"></param>
        /// <returns></returns>

        private static Task<Stock> GetStockAsync(string url, string site, string dataSource,
            string symbol, char[] separators, int dataIndex, int yearsOfHistory, 
            out HttpWebRequest request)
        {
            request = (HttpWebRequest)HttpWebRequest.Create(url);

            var webTask = Task.Factory.FromAsync<WebResponse>(
                request.BeginGetResponse,
                request.EndGetResponse,
                null);

            var resultTask = webTask.ContinueWith<Stock>(antecedent =>
            {
                if (!antecedent.Status.Equals(TaskStatus.Faulted))
                {
                    var response = (HttpWebResponse)antecedent.Result;

                    List<decimal> prices = ParsePrices(response, separators, dataIndex);

                    return new Stock(symbol, site, dataSource, prices);
                }
                return new Stock(symbol, site, dataSource, new List<decimal>());
            });

            return resultTask;
        }// End GetStockAsync
        /// <summary>
        /// Tries to fetch historical stock data from Yahoo or Nasdaq
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="yearsOfHistory"></param>
        /// <returns></returns>
        private static Stock GetStockData(string symbol, int yearsOfHistory)
        {
            if (!IsInternetAvailable)
                throw new ApplicationException("No internet available.");

            HttpWebRequest req_yahoo, req_nasdaq;

            DateTime today = DateTime.Now;
            string urlYahoo = string.Format(urlTemplateYahoo, symbol, today.Month - 1,
                today.Day - 1, today.Year, today.Year - yearsOfHistory);
            
            string urlNasdaq = string.Format(urlTemplateNasdaq, symbol);

            Task<Stock> yahoo = GetStockAsync(
                urlYahoo, "Http://finance.yahoocom",
                string.Format("Daily Adj Close, {0} years",
                yearsOfHistory), symbol, new char[] { ',' },
                6, yearsOfHistory, out req_yahoo);

            Task<Stock> nasdaq = GetStockAsync(urlNasdaq, "http://nasdaq.com",
                string.Format("Daily Close, {0} years", yearsOfHistory),
                symbol, new char[] { '\t' }, 4, yearsOfHistory, out req_nasdaq);

            var tasks = new List<Task<Stock>>();
            var requests = new List<HttpWebRequest>();

            tasks.Add(yahoo);
            tasks.Add(nasdaq);

            requests.Add(req_yahoo);
            requests.Add(req_nasdaq);

            Stock result = null;

            // Use the result from the first Task that returns without exception
            while (tasks.Count > 0)
            {
                int taskIndex = -1;

                // The index of the completed task in the tasks array,
                // or if taskIndex < 0 then a timeout occured
                taskIndex = Task.WaitAny(tasks.ToArray(), 15000);

                if (taskIndex < 0) break; // timeout occured

                // Get the result from the task if it was successful
                if (tasks[taskIndex].Exception == null && tasks[taskIndex].Result.HasPrices)
                    result = tasks[taskIndex].Result;

                // Remove the Task from the tasks collection 
                // and the request from the requests collection
                tasks.RemoveAt(taskIndex);
                requests.RemoveAt(taskIndex);
            }

            // Cancel any remaining requests
            foreach (HttpWebRequest r in requests)
                r.Abort();

            // Return the result if it contains data
            if (result != null)
                return result;
            else
                // Throw exception if none of the websites could produce data
                throw new ApplicationException("Could not fetch data from any of the web sites.");
        }

        #endregion



        #region Event Handlers
        /// <summary>
        /// In this application several Tasks are started to get the stock data
        /// but only the first one to return is processed, the other Tasks are cancelled.
        /// Cancelled Tasks need to be observed otherwise the Garbage Collection will
        /// throw exceptions during clean-up of the Task objects. The following event 
        /// handler is a work-around this pronlem.
        /// 
        /// NOTE: that this event handler is registered with the class' static constructor 
        /// to only be registered once.
        private static void TaskUnobservedException_Handler(object sender, UnobservedTaskExceptionEventArgs e)
        {
            /* Ignore all subsquent Tasks since the result from the first Task to 
               return a result already has been processed */
            e.SetObserved();
        }
        #endregion

    }
}

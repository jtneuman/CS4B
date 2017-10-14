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

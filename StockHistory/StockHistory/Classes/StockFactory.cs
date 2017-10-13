using System;
using System.Collections.Generic;
using System.Linq;
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

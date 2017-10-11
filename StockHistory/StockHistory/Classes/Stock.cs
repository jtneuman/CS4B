using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockHistory.Classes
{
    class Stock
    {
        #region Properties

        public string Symbol { get; private set; }
        public string Site { get; private set; }
        public string DataSource { get; private set; }
        public bool HasPrices { get; private set; }
        public decimal DataPoints { get;  private set; }
        public decimal Max { get; private set; }
        public decimal Min { get; private set; }
        public decimal Avg { get; private set; }

        #endregion

        #region Contructors

        public Stock(string symbol, string site, string dataSource,
            List<decimal> prices)
        {
            Symbol = symbol;
            Site = site;
            DataSource = dataSource;
            HasPrices = prices.Count > 0;
            DataPoints = prices.Count;
            ProcessStock(prices);
        }

        #endregion

        #region Methods

        private void ProcessStock(List<decimal> prices)
        {
            if (prices == null || prices.Count.Equals(0)) return;

            var T_min = Task.Run<decimal>(() => prices.Min());
            var T_max = Task.Run<decimal>(() => prices.Max());
            var T_avg = Task.Run<decimal>(() => prices.Average());

            try
            {
                Task.WaitAll(new Task[] { T_min, T_max, T_avg });
                Min = T_min.Result;
                Max = T_max.Result;
                Avg = T_avg.Result;
            }
            catch 
            {
            }

        }

        #endregion


    }
}

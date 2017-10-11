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

        #endregion


    }
}

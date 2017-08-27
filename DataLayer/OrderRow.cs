using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class OrderRow
    {
        public int OrderRowId { get; set; }
        public int OrderId { get; set; }
        public string Product { get; set; }
        public double? Price { get; set; }

        internal OrderRow(int orderId, int orderRowId,
            string product, double? price)
        {
            OrderId = orderId;
            OrderRowId = orderRowId;
            Product = product;
            Price = price;
        }

    }
}

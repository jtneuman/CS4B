using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Description { get; set; }

        internal Order(int orderId, string description)
        {
            OrderId = orderId;
            Description = description;
        }
    }
}

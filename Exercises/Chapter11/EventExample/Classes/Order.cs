using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Chapter11.EventExample.Classes
{
    class Order
    {
        public delegate void OrderRowAddHandler(OrderRow row);
        public event OrderRowAddHandler OrderRowAdded;

        List<OrderRow> orderRows = new List<OrderRow>();

        public List<OrderRow> GetOrderRows()
        {
            return orderRows.OrderBy(or => or.Id).ToList();
        }

        public void AddOrderRow(Product product, int quantity)
        {
            // Create a new order row with the passed in
            // information and add the order row to the 
            // order rows collection
            var orderRow = new OrderRow(product, quantity);
            orderRows.Add(orderRow);

            // Raise the event if there are subscribers
            if (OrderRowAdded != null)
                OrderRowAdded(orderRow);
        }
    }
}

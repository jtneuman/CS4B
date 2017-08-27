using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Data
    {
        #region Variables
        List<Order> orders = new List<Order>();
        List<OrderRow> orderRows = new List<OrderRow>();

        #endregion

        #region Order Methods
        public Order AddOrder(string description)
        {
            try
            {
                int newId = orders.Count.Equals(0) ? 1 :
                    orders.Max(o => o.OrderId) + 1;
                var order = new Order(newId, description);
                orders.Add(order);
                return order;
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Could not add the order", ex);
            }
        }

        public List<Order> GetOrders()
        {
            return orders;
        }
        #endregion

    }
}

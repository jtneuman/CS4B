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

        public bool ContainsOrder(string description)
        {
            return orders.Count(o => o.Description.Equals(description)) > 0;
        }

        public bool UpdateOrder(int orderId, string description)
        {
            try
            {
                var order = orders.FirstOrDefault(o =>
                    o.OrderId.Equals(orderId));
                order.Description = description;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool RemoveOrder(int orderId)
        {
            try
            {
                orderRows.RemoveAll(or =>
                    or.OrderId.Equals(orderId));
                orders.RemoveAll(o => o.OrderId.Equals(orderId));
                return true;
            }
            catch
            {

                return false;
            }
        }
        #endregion

        #region Order Row Methods
        public List<OrderRow> GetOrderRows(int orderId)
        {
            return orderRows.Where(or => or.OrderId.Equals(orderId)).ToList();
        }
        // to return an instance of the OrderRow class to use when a new order row is added to an existing order
        public OrderRow EmptyOrderRow()
        {
            return new OrderRow(0, 0, String.Empty, null);
        }
        // to add a new order row to an existing order
        public OrderRow AddOrderRow(OrderRow orderRow)
        {
            try
            {
                int newId = orderRows.Count.Equals(0) ? 1 :
                    orderRows.Max(o => o.OrderRowId) + 1;
                orderRow.OrderRowId = newId;
                orderRows.Add(orderRow);
                return orderRow;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(
                    "Could not add the order row", ex);
            }
        }
        // To remove an order row instance from the orderRows collection in the Data class
        public bool RemoveOrderRow(OrderRow orderRow)
        {
            return orderRows.Remove(orderRow);
        }
        #endregion

    }
}

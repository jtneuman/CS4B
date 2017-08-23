using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders
{
    public partial class Orders : Form
    {
#region Order struct
        struct Order
        {
            private int _customerId;
            private double _total;
            private Guid _orderNo;

            public int CustomerId
            {
                get { return _customerId; }
                set { _customerId = value; }
            }

            public double Total
            {
                get { return _total; }
                set { _total = value; }
            }

            public Guid OrderNo
            {
                get { return _orderNo; }
                set { _orderNo = value; }
            }

            public Order(int customerId, double total, Guid orderNo)
            {
                _customerId = customerId;
                _total = total;
                _orderNo = orderNo;
            }

        }
        #endregion
#region Customer struct
        struct Customer
        {
            private int _id;
            private string _name;

            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public Customer(int id, string name)
            {
                _id = id;
                _name = name;
            }

        }
        #endregion

        List<Customer> customers = new List<Customer>();
        List<Order> fulfilledOrders = new List<Order>();
        Queue<Order> orders = new Queue<Order>();

        public Orders()
        {
            customers.AddRange(new Customer[]
            {
                new Customer(1, "John Doe"),
                new Customer(2, "Stan Smith")
            });

            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            cboCustomers.DataSource = customers;
            cboCustomers.DisplayMember = "Name";
        }

#region Methods
        private void ShowCustomerOrders(int customerId)
        {
            var customer = customers.First(c => c.Id.Equals(customerId));
            var nextOrderNo = orders.Count > 0 ? orders.Peek().OrderNo : Guid.Empty;

            var items = (from o in orders
                         where o.CustomerId.Equals(customer.Id)
                         select new
                         {
                             Color = o.OrderNo.Equals(nextOrderNo) ?
                                Color.LightBlue : Color.LightPink,
                             Item = new ListViewItem(new string[]
                             {
                                 o.OrderNo.ToString(), o.Total.ToString(),
                                 customer.Name, customer.Id.ToString()
                             })
                         }).Union(
                                from o in fulfilledOrders
                                where o.CustomerId.Equals(customer.Id)
                                select new
                                {
                                    Color = Color.LightGreen,
                                    Item = new ListViewItem(new string[]
                                    {
                                        o.OrderNo.ToString(), o.Total.ToString(),
                                        customer.Name, customer.Id.ToString()
                                    })
                                });  // End of Union

            lstOrders.Items.Clear();
            foreach (var item in items)
            {
                item.Item.BackColor = item.Color;
                lstOrders.Items.Add(item.Item);
            }
        }

        #endregion

        private void cboCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomers.Items.Count.Equals(0)) return;
            var customer = (Customer)cboCustomers.SelectedItem;
            ShowCustomerOrders(customer.Id);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex.Equals(0))
            {
                if (cboCustomers.Items.Count.Equals(0)) return;
                var customer = (Customer)cboCustomers.SelectedItem;
                ShowCustomerOrders(customer.Id);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            var total = 0d;
            var success = Double.TryParse(txtTotal.Text, out total);
            if (success)
            {
                var customerId = ((Customer)cboCustomers.SelectedItem).Id;
                var order = new Order(customerId, total, Guid.NewGuid());
                orders.Enqueue(order);

                ShowCustomerOrders(customerId);
            }
        }
    }
}

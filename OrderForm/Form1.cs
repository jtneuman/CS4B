using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class Form1 : Form
    {

        struct Order
        {
            private string _orderNo;
            private string _description;

            public string OrderNo
            {
                get { return _orderNo; }
            }

            public string Description
            {
                get { return _description; }
            }

            public Order(string orderNo, string description)
            {
                _orderNo = orderNo;
                _description = description;
            }
        }

        Queue<Order> orders = new Queue<Order>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblInQueue.Text = String.Format("Orders in Queue: {0}", orders.Count);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            orders.Enqueue(new Order(txtOrderNo.Text, txtDescription.Text));
            lblInQueue.Text = String.Format("Orders in Queue: {0}", orders.Count);

            lstOrders.Items.Clear();
            foreach (var order in orders)
            {
                lstOrders.Items.Add(String.Format(
                    "Order [{0}] {1}", order.OrderNo, order.Description));
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (orders.Count.Equals(0)) return;
            var order = orders.Dequeue();
            lblInQueue.Text = String.Format("Orders in Queue: {0}", orders.Count);

            MessageBox.Show(String.Format("Order [{0}] {1}",
                order.OrderNo, order.Description));

            lstOrders.Items.Clear();
            foreach (var item in orders)
            {
                lstOrders.Items.Add(String.Format(
                    "Order [{0}] {1}", item.OrderNo, item.Description));
            }

        }
    }
}

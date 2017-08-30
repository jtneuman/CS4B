using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercises.Chapter11.EventExample.Classes;

namespace Exercises.Chapter11.EventExample
{
    public partial class EventExampleMain : Form
    {
        Order order = new Order();
        List<Product> products = new List<Product>();

        public EventExampleMain()
        {
            products.Add(new Product { Id=1, Price = 10.5,
                Title = "Product 1"});
            products.Add(new Product
            {
                Id = 2,
                Price = 20,
                Title = "Product 2"
            });
            products.Add(new Product
            {
                Id = 3,
                Price = 5,
                Title = "Product 3"
            });

            InitializeComponent();

            cboProducts.DataSource = products;
            cboProducts.DisplayMember = "Title";
        }

        private void EventExampleMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAddOrderRow_Click(object sender, EventArgs e)
        {
            // subscribe to the event
            order.OrderRowAdded += Order_OrderRowAdded;

            order.AddOrderRow((Product)cboProducts.SelectedItem,
                (int)nudProductQuantity.Value);

            // unsubscribe from the event
            order.OrderRowAdded -= Order_OrderRowAdded;
        }

        private void Order_OrderRowAdded(OrderRow row)
        {
            var idx = order.GetOrderRows().IndexOf(row);

            dgvProductOrderRows.DataSource = null;
            dgvProductOrderRows.DataSource = order.GetOrderRows();

            foreach (DataGridViewColumn column in dgvProductOrderRows.Columns)
                column.Width = 90;
                
            dgvProductOrderRows.Columns[1].Width = 180;

            foreach (DataGridViewCell cell in dgvProductOrderRows.Rows[idx].Cells)
                cell.Style.BackColor = Color.LightGreen;

        }
    }
}

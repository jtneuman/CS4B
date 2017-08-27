using DataLayer;
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
    public partial class CLformAddOrderRow : Form
    {
        #region Properties
        private OrderRow OrderRow { get; set; }
        #endregion

        #region Constructor
        public CLformAddOrderRow(OrderRow orderRow)
        {
            OrderRow = orderRow;

            InitializeComponent();
        } 
        #endregion

        private void CLformAddOrderRow_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double price = 0d;
            var success = Double.TryParse(txtPrice.Text, out price);

            if (success)
            {
                OrderRow.Product = txtProduct.Text;
                OrderRow.Price = price;
                DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                MessageBox.Show("Price not valid");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}

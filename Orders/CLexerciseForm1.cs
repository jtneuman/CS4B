using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace Orders
{
    public partial class CLexerciseForm1 : Form
    {
        #region Variables
        Data data = new Data();
        BindingList<Order> orders;
        BindingList<OrderRow> orderRows;
        #endregion

        public CLexerciseForm1()
        {
            InitializeComponent();
        }

        private void CLexerciseForm1_Load(object sender, EventArgs e)
        {
            try
            {
                data.AddOrder("Order 1");
                data.AddOrder("Order 2");
                orders = new BindingList<Order>(data.GetOrders());

                cboOrders.DataSource = orders;
                cboOrders.DisplayMember = "Description";

                txtDescription.DataBindings.Add(
                    "Text", orders, "Description",
                    false, DataSourceUpdateMode.Never);

                dgvOrderRows.Columns[0].Visible = false;
                dgvOrderRows.Columns[1].Visible = false;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
            catch /*(Exception ex)*/
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescription.TextLength.Equals(0))
                {
                    MessageBox.Show("Description is empty!");
                    return;
                }
                if (data.ContainsOrder(txtDescription.Text))
                {
                    MessageBox.Show("Description already exists!");
                    return;
                }

                var order = data.AddOrder(txtDescription.Text);
                orders.ResetBindings();
                cboOrders.SelectedItem = order;
            }
            catch (ApplicationException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (orders.Count.Equals(0)) return;

            var success = data.UpdateOrder(
                ((Order)cboOrders.SelectedItem).OrderId,
                txtDescription.Text);

            if (success) orders.ResetBindings();
        }



        #region Methods
        private void UpdateOrderRowBindings()
        {
            if (cboOrders.SelectedItem == null)
            {
                dgvOrderRows.Rows.Clear();
                return;
            }
            int orderId = ((Order)cboOrders.SelectedItem).OrderId;
            orderRows = new BindingList<OrderRow>(data.GetOrderRows(orderId));
            dgvOrderRows.DataSource = orderRows;
        }
        #endregion

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            if (orders.Count.Equals(0)) return;

            var success = data
                .RemoveOrder(((Order)cboOrders.SelectedItem).OrderId);
            if (success)
            {
                orders.ResetBindings();
                UpdateOrderRowBindings();
            }
        }
        // To add a new order row to an existing order.
        private void btnAddOrderRow_Click(object sender, EventArgs e)
        {
            var orderRow = data.EmptyOrderRow();
            var result = ShowAddOrderRowForm(orderRow);

            if (result.Equals(DialogResult.Cancel)) return;

            orderRow.OrderId = orders[cboOrders.SelectedIndex].OrderId;
            orderRow = data.AddOrderRow(orderRow);
            UpdateOrderRowBindings();
        }

        #region Methods
        // To display the "Add Order Row" form and return the result.
        private DialogResult ShowAddOrderRowForm(OrderRow orderRow)
        {
            // Create the form instance
            var frm = new CLformAddOrderRow(orderRow);

            // Position the form
            frm.StartPosition = FormStartPosition.Manual;
            var location = this.Location;
            location.Offset(40, 40);
            frm.Location = location;

            // Open the form and return the result of the clicked button
            DialogResult result = frm.ShowDialog();
            return result;
        }
        #endregion

        private void cboOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOrderRowBindings();
        }

        private void dgvOrderRows_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var orderRow = (OrderRow)e.Row.DataBoundItem;
            data.RemoveOrderRow(orderRow);
        }
    }//end of CLexerciseForm1 class
}

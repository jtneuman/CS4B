using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Orders.Classes;

namespace Orders
{
    public partial class Form1 : Form
    {
        BindingList<Customer> customers = new BindingList<Customer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Binding the combo box to the data source
            cboCustomers.DataSource = customers;
            cboCustomers.DisplayMember = "Name"; // assigning name prop from cust class to displaymember property
            // Binding textboxes to data source
            // Add (Property in the control, data source,
            //property in the data source, format text, update mode)
            txtFirstName.DataBindings.Add("Text", customers,
                "FirstName", false, DataSourceUpdateMode.Never);
            txtLastName.DataBindings.Add("Text", customers,
                "LastName", false, DataSourceUpdateMode.Never);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Equals(String.Empty) ||
                txtLastName.Text.Equals(String.Empty))
                return;

            var customer = new Customer(txtFirstName.Text, txtLastName.Text);
            customers.Add(customer);
            cboCustomers.SelectedIndex = cboCustomers.Items.Count - 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cboCustomers.SelectedIndex.Equals(-1)) return;

            if (txtFirstName.Text.Equals(String.Empty) ||
                txtLastName.Text.Equals(String.Empty))
                return;

            var customer = customers[cboCustomers.SelectedIndex];
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;

            customers.ResetBindings();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cboCustomers.SelectedIndex >= 0)
                customers.RemoveAt(cboCustomers.SelectedIndex);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer.Classes;
using Business_Layer.Interfaces;
using Data_Layer.Data_Layers;
using Data_Layer.Entities;
using Data_Layer.Enums;
using Data_Layer.Interfaces;
using Car_Rental.Classes;
using System.Text.RegularExpressions;

namespace Car_Rental
{
    public partial class Form1 : Form
    {

        IBookingProcessor processor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processor = new BookingProcessor(new CollectionDataLayer());

            FillCustomers();
            FillAvailableVehicles();
            FillBookedVehicles();
            FillBookedVehicles();
            FillVehicleTypes();
        }

        #region Fill Data Methods


        private void FillCustomers()
        {
            try
            {
                var customer = from c in processor.GetCustomers()
                               select new ComboCustomer
                               {
                                   Name = String.Format("{0} {1} {2}",
                                   c.LastName, c.FirstName, c.SocialSecurityNumber),
                                   SocialSecurityNumber = c.SocialSecurityNumber,
                                   Id = c.Id
                               };
                cboCustomers.Items.Clear();
                cboCustomers.Items.AddRange(customer.ToArray());
                cboCustomers.DisplayMember = "Name";
            }
            catch (Exception)
            {

                throw;
            }
        }// end fill customers method

        private void FillAvailableVehicles()
        {
            var vehicles = GetVehicles(VehicleStatus.Available);
            lvwAvailableVehicles.Items.Clear();
            lvwAvailableVehicles.Items.AddRange(vehicles.ToArray());
        }

        private void FillBookedVehicles()
        {
            var vehicles = GetVehicles(VehicleStatus.Booked);
            lvwBookedVehicles.Items.Clear();
            lvwBookedVehicles.Items.AddRange(vehicles.ToArray());
        }

        private bool FillBookings()
        {
            bool returnValue = false;

            try
            {
                var bookings =
                    from b in processor.GetBookings()
                    join c in processor.GetCustomers()
                        on b.CustomerId equals c.Id
                    join car in processor.GetVehicles(VehicleStatus.All)
                        on b.VehicleId equals car.Id
                    select new ListViewItem(new ListViewBooking
                    {
                        BookingId = b.Id,
                        CustomerId = b.CustomerId,
                        Cost = b.Cost,
                        Customer = String.Format("{0} {1}", c.FirstName, c.LastName),
                        RegistrationNumber = car.RegistrationNumber,
                        VehicleType = processor.GetVehicleType(car.TypeId).Name,
                        Rented = b.Rented,
                        Returned = b.Returned
                    }.ToArray());

                lvwBookings.Items.Clear();
                lvwBookings.Items.AddRange(bookings.ToArray());

                returnValue = true;
            }
            catch (Exception)
            {

                returnValue = false;
            }
            return returnValue;
        }

        private void FillVehicleTypes()
        {
            try
            {
                cboTypes.DataSource = processor.GetVehicleTypes();
                cboTypes.DisplayMember = "Name";
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion


        #region Fetch Data Methods

        private IEnumerable<ListViewItem> GetVehicles(VehicleStatus vehicleStatus)
        {
            return from v in processor.GetVehicles(vehicleStatus)
                   select new ListViewItem(new string[]
                   {
                       processor.GetVehicleType(v.TypeId).Name,
                       v.RegistrationNumber,
                       v.BasePricePerKm.ToString(),
                       v.BasePricePerDay.ToString(),
                       v.Meter.ToString(),
                       v.Id.ToString(),
                       "0" // BookingId
                   });
        }



        #endregion

        #region Action Methods

        private bool RentVehicle()
        {
            bool returnValue = false;
            try
            {
                if(cboCustomers.SelectedIndex < 0)
                {
                    MessageBox.Show(
                        "A Customer must be selected in the drop down list");
                    return returnValue;
                }
                if(lvwAvailableVehicles.SelectedItems.Count == 0)
                {
                    MessageBox.Show("A vehicle must be selected in the list");
                    return returnValue;
                }

                var vehicledId = Int32.Parse(
                    lvwAvailableVehicles.SelectedItems[0].SubItems[5].Text);

                var customerId = ((ComboCustomer)cboCustomers.SelectedItem).Id;

                var ok = processor.RentVehicle(vehicledId, customerId, DateTime.Now);
                FillAvailableVehicles();
                FillBookedVehicles();
                FillBookings();

                returnValue = true;
            }
            catch 
            {
                returnValue = false;
            }
            return returnValue;
        }// end RentVehicle method

        private bool ReturnVehicle()
        {
            bool returnValue = false;

            try
            {
                if (!IsNumeric(txtMeterReturn.Text))
                {
                    MessageBox.Show("The meter setting must be a number");
                    return returnValue;
                }
                if (lvwBookedVehicles.SelectedItems.Count == 0)
                {
                    MessageBox.Show("A vehicle must be selected in the list");
                    return returnValue;
                }

                var vehicleId = Int32.Parse(
                    lvwBookedVehicles.SelectedItems[0].SubItems[5].Text);

                var bookingId = processor.GetBooking(vehicleId).Id;
                var ok = processor.ReturnVehicle(bookingId,
                    double.Parse(txtMeterReturn.Text), DateTime.Now);

                FillAvailableVehicles();
                FillBookedVehicles();
                FillBookings();

                txtMeterReturn.Text = String.Empty;

                returnValue = true;
            }
            catch (Exception)
            {

                returnValue = false;
            }
            return returnValue;
        }

        private bool AddVehicle(IVehicle vehicle)
        {
            bool returnValue = false;

            try
            {
                //Check the controls for erroneous data
                string errMsg = String.Empty;
                if (txtRegNo.TextLength == 0)
                    errMsg = "Incorrect vehicle registration number" +
                        Environment.NewLine;
                if (cboTypes.SelectedIndex < 0)
                    errMsg += "No vehicle type selected" +
                        Environment.NewLine;
                if (!IsNumeric(txtMeter.Text) ||
                    (IsNumeric(txtMeter.Text) && Double.Parse(txtMeter.Text) < 0))
                    errMsg += "The meter value is incorrect" +
                        Environment.NewLine;
                if (!IsNumeric(txtMeter.Text) ||
                    Double.Parse(txtMeter.Text) < 0 || txtRegNo.TextLength == 0 ||
                    cboTypes.SelectedIndex < 0)
                {
                    MessageBox.Show(errMsg);
                    // this is set as (return false;) in example but gives an comp error.
                    return returnValue;
                }
                // assign data to the vehicle object
                var type = ((VehicleType)cboTypes.SelectedItem);
                var car = new Car() { 
                Meter = Double.Parse(txtMeter.Text),
                RegistrationNumber = txtRegNo.Text,
                TypeId = type.Id,
                BasePricePerDay = type.BasePricePerDay,
                BasePricePerKm = type.BasePricePerKm,
                DayTariff = type.DayTariff,
                KmTariff = type.KmTariff
            };
                // Add the vehicle obj to the Vehicles collection
                processor.AddVehicle(car);

                // Update the vehicle list on the Rent Vehicles tab
                FillAvailableVehicles();

                txtRegNo.Text = String.Empty;
                txtMeter.Text = String.Empty;

                returnValue = true;
            }
            catch (Exception)
            {

                returnValue = false;
            }
            return returnValue;
        }

        private int AddCustomer()
        {
            int returnValue = -1;

            try
            {
                // Check for erroneous data
                string errMsg = String.Empty;
                if (txtSocialSecurityNumber.TextLength == 0)
                    errMsg = "Invalid SSN" + Environment.NewLine;

                if (txtFirstName.TextLength == 0)
                    errMsg += "Incorrect first name" + Environment.NewLine;

                if (txtLastName.TextLength == 0)
                    errMsg += "Incorrect last name" + Environment.NewLine;

                if (txtSocialSecurityNumber.TextLength == 0 ||
                    txtFirstName.TextLength == 0 || 
                    txtLastName.TextLength == 0)
                {
                    MessageBox.Show(errMsg);
                    //return -1;
                    return returnValue;
                }
                // Create the new customer object
                var customer = new Customer()
                {
                    SocialSecurityNumber = txtSocialSecurityNumber.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text
                };
                // Add the new customer to the Customers collection and update the combo box
                processor.AddCustomer(customer);
                FillCustomers();

                txtSocialSecurityNumber.Text = String.Empty;
                txtFirstName.Text = String.Empty;
                txtLastName.Text = String.Empty;

                //return cboCustomers.Items.Count - 1;
                returnValue = cboCustomers.Items.Count - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //return -1;
            }

            return returnValue;  
            
        }

        #endregion

        #region Helper Methods
        public bool IsNumeric(string text)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(text);
        }



        #endregion

        #region Button Events

        private void btnRent_Click(object sender, EventArgs e)
        {
            var rented = RentVehicle();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var returned = ReturnVehicle();

            if (!returned) MessageBox.Show("The vehicle was not returned");
        }

        private void tabRentVehicle_Click(object sender, EventArgs e)
        {

        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                var added = AddVehicle(new Car());

                if (!added)
                    MessageBox.Show("The vehicle was not added");
                //tabAddData.Update(tabRentVehicle);
                // tabBooking.SelectTab(tabRentVehicle); > listed in book like this but only works as written below.
                tabControl1.SelectedTab = tabRentVehicle;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //Customer added = AddCustomer(new Customer());
            var idx = AddCustomer();

            //if (idx.Equals(Int32.MinValue)) return;
            //if (idx.Equals(-1))
            //{
            //    MessageBox.Show("The customer was not added");
            //    return;
            //}
            if (idx == -1)
            {
                MessageBox.Show("The customer was not added");
                return;
            }

            //cboCustomers.SelectedIndex = idx;
            cboCustomers.SelectedIndex = idx;
            tabControl1.SelectedTab = tabRentVehicle;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var success = IO.WriteToFile(@"C:\Test\Customers.txt", processor.GetCustomers());
            if (success)
                MessageBox.Show("Customers were saved to file");
            else
                MessageBox.Show("Customers could not be saved at this time.");
        }


        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            processor.DataLayer.Serialize(@"C:\Test\");
        }
    }
}

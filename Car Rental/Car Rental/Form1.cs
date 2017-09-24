﻿using System;
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
using Data_Layer.Enums;
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

                return true;
            }
            catch (Exception)
            {

                return false;
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
            bool success = false;
            try
            {
                if(cboCustomers.SelectedIndex < 0)
                {
                    MessageBox.Show(
                        "A Customer must be selected in the drop down list");
                    return success;
                }
                if(lvwAvailableVehicles.SelectedItems.Count == 0)
                {
                    MessageBox.Show("A vehicle must be selected in the list");
                    return success;
                }

                var vehicledId = Int32.Parse(
                    lvwAvailableVehicles.SelectedItems[0].SubItems[5].Text);

                var customerId = ((ComboCustomer)cboCustomers.SelectedItem).Id;

                success = processor.RentVehicle(vehicledId, customerId, DateTime.Now);
                FillAvailableVehicles();
                FillBookedVehicles();
                FillBookings();
            }
            catch 
            {
                success = false;
            }
            return success;
        }

        #endregion

        private bool ReturnVehicle()
        {
            bool success = false;

            try
            {
                if (!IsNumeric(txtMeterReturn.Text))
                {
                    MessageBox.Show("The meter setting must be a number");
                    return success;
                }
                if (lvwBookedVehicles.SelectedItems.Count == 0)
                {
                    MessageBox.Show("A vehicle must be selected in the list");
                    return success;
                }

                var vehicleId = Int32.Parse(
                    lvwBookedVehicles.SelectedItems[0].SubItems[5].Text);

                var bookingId = processor.GetBooking(vehicleId).Id;
                processor.ReturnVehicle(bookingId,
                    double.Parse(txtMeterReturn.Text), DateTime.Now);

                FillAvailableVehicles();
                FillBookedVehicles();
                FillBookings();

                txtMeterReturn.Text = String.Empty;

                success = true;
            }
            catch (Exception)
            {

                success = false;
            }
            return success;
        }

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

        #endregion

        private void tabRentVehicle_Click(object sender, EventArgs e)
        {

        }


    }
}

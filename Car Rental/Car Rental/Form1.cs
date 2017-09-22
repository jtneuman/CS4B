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



        #endregion

        #region Helper Methods



        #endregion

        #region Button Events



        #endregion

        private void tabRentVehicle_Click(object sender, EventArgs e)
        {

        }
    }
}

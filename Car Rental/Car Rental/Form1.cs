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
        }


        #region Fill Data Methods



        #endregion

        #region Action Methods



        #endregion

        #region Helper Methods



        #endregion

        #region Button Events



        #endregion


    }
}

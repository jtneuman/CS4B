using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapCoordinates
{
    public partial class Form1 : Form
    {
#region Structs
        struct MapPoint
        {
            private double _latitude, _longitude;
            private string _city;

            public double Longitude
            {
                get { return _longitude; }
                set => _longitude = value;
            }

            public double Latitude
            {
                get { return _latitude; }
                set { _latitude = value; }
            }


            public string City
            {
                get { return _city; }
                set { _city = value; }
            }

            public MapPoint(double latitude, double longitude, string city)
            {
                _latitude = latitude;
                _longitude = longitude;
                _city = city;
            }            

        }
        #endregion
        List<MapPoint> map = new List<MapPoint>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        private void btnAddCoordinate_Click(object sender, EventArgs e)
        {
            double latitude, longitude;
            var isLatitude = Double.TryParse(
                txtLatitude.Text.Replace(',', '.'), out latitude);
            var isLongitude = Double.TryParse(
                txtLongitude.Text.Replace(',', '.'), out longitude);

            if (isLatitude && isLongitude)
            {
                var coordinate = new MapPoint(latitude, longitude,
                    txtCity.Text);
                map.Add(coordinate);
                lstCoordinates.Items.Add(String.Format(
                    "{0} [{1}, {2}]", coordinate.City,
                    coordinate.Latitude, coordinate.Longitude));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstCoordinates.SelectedIndex > -1)
            {
                var index = lstCoordinates.SelectedIndex;
                map.RemoveAt(index);
                lstCoordinates.Items.RemoveAt(index);
            }
        }
    }
}

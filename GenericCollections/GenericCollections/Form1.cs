using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenericCollections.Classes;
using GenericCollections.Interfaces;

namespace GenericCollections
{

    public partial class Form1 : Form
    {
        ArrayList vehicles = new ArrayList();
        List<Car> cars;

        public Form1()
        {
            InitializeComponent();

            #region ArrayList collection
            vehicles.Add(new Car { RegNo = "ABC123", Model = "Volvo" });
            vehicles.Add(new Car { RegNo = "XYZ123", Model = "Saab" });
            vehicles.Add(new Motorcycle { RegNo = "QWE987", Model = "Honda" });
            #endregion

            #region Generic collection

            cars = new List<Car>
            {
                new Car { RegNo = "ABC123", Model = "Volvo" },
                new Car { RegNo = "XYZ123", Model = "Saab" }
            };

            #endregion
        }

        private void btnCollections_Click(object sender, EventArgs e)
        {
            foreach (var vehicle in vehicles)
            {
                cboCars.Items.Add((Car)vehicle);
            }
        }

        private void btnCollectionWithInterface_Click(object sender, EventArgs e)
        {
            foreach (var vehicle in vehicles)
            {
                cboCars.Items.Add(((IVehicle)vehicle).RegNo);
            }
        }

        private void btnGenericCollection_Click(object sender, EventArgs e)
        {
            cboCars.DataSource = cars;
            cboCars.DisplayMember = "RegNo";
        }
    }
}

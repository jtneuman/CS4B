using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpecializedCollections.Interfaces;
using SpecializedCollections.Classes;

namespace SpecializedCollections
{
    public partial class Form1 : Form
    {
        Repository<Car> carRepository = new Repository<Car>();
        Repository<Motorcycle> mcRepository = new Repository<Motorcycle>();

        public Form1()
        {
            InitializeComponent();

            carRepository.Add(new Car
            {
                RegNo = "ABC123",
                Model = "Volvo",
                IsRegistered = false
            });

            carRepository.Add(new Car
            {
                RegNo = "GFD123",
                Model = "Corvette",
                IsRegistered = false
            });

            carRepository.Add(new Car
            {
                RegNo = "XYZ123",
                Model = "Saab",
                IsRegistered = true
            });

            carRepository.Add(new Car
            {
                RegNo = "LKJ123",
                Model = "Koenigsegg",
                IsRegistered = true
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInterfaceConstraint_Click(object sender, EventArgs e)
        {
            if (rbnAll.Checked)
                lstItems.DataSource = carRepository.Get();
            else
                lstItems.DataSource = carRepository.Get(
                    rbnRegistered.Checked ? true : false).ToList();
            lstItems.DisplayMember = "DisplayValue";
        }
    }
}

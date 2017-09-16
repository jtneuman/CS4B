using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpecializedCollections.Classes;

namespace GuiForSearchExtensionMethod
{
    public partial class Form1 : Form
    {
        Repository<Car> carRepository = new Repository<Car>();

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

        } // End constructor

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstResult.DataSource = carRepository.Search(txtSearch.Text);
            lstResult.DisplayMember = "DisplayValue";
        }
    }
}

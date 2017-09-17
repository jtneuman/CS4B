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
    public partial class SearchForm : Form
    {
        Repository<Car> carRepository = new Repository<Car>();

        public SearchForm()
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

        private void btnPrintToListBox_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
            carRepository.Search(txtSearch.Text).Output(
                a => lstResult.Items.Add(a.DisplayValue));
        }

        private void btnCallFunc_Click(object sender, EventArgs e)
        {
            // Create a Func which takes a string (search)
            // and return a Car object by calling the 
            // Search method with the search text and 
            // returning the first item found.
            Func<string, Car> FirstMatch = search => // defines the Func delegate
                carRepository.Search(search).FirstOrDefault(); // the method called

            //Call the Func
            var result = FirstMatch(txtSearch.Text);

            // Display the result
            lblResult.Text = result != null ? result.DisplayValue : "No car found";
        }

        private void btnCallPredicate_Click(object sender, EventArgs e)
        {
            Predicate<string> Contains = search => // defines the predicate delegate
                carRepository.Search(search).Count() > 0; //the method to call
            // Call the predicate and display the result
            var result = Contains(txtSearch.Text);
            lblResult.Text = result.ToString();
        }
    }
}

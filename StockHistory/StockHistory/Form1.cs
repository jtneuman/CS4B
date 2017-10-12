using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockHistory.Classes;
using System.Threading;

namespace StockHistory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Methods

        private List<Stock> GetData(List<string> symbols,
            int yearsOfHistory = 1)
        {
            Thread.Sleep(2000);
            return null;
        }

        private string FormatOutput(List<Stock> stocks)
        {
            Thread.Sleep(2000);
            return null;
        }

        #endregion



        private async void BtnGetStockData_Click(object sender, EventArgs e)
        {
            try
            {
                BtnGetStockData.Enabled = false;
                TxtResult.Text = String.Empty;

                var symbols = new List<string> { "msft", "intc" };
                var stocks = await Task.Run(() => GetData(symbols, 2));
                var output = await Task.Run(() => FormatOutput(stocks));
                
                TxtResult.Text = output;
                BtnGetStockData.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }// end BtnGetStockData click event
    }
}

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
using System.Globalization;

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
            //Thread.Sleep(2000);
            //return null;

            var stocks = new List<Stock>();
            var tasks = new List<Task>();

            foreach (var symbol in symbols)
            {
                Task task = Task.Factory.StartNew((t_symbol) =>
                {
                    var stock = StockFactory.GetStockData(t_symbol.ToString(),
                        yearsOfHistory);
                    stocks.Add(stock);
                }, symbol);

                tasks.Add(task);
            }

            // Wait for all tasks to complete
            Task.WaitAll(tasks.ToArray());
            return stocks;
        }

        private string FormatOutput(List<Stock> stocks)
        {
            //Thread.Sleep(2000);
            //return null;
            var output = new StringBuilder();
            var culture = new CultureInfo("en-US");

            foreach (var stock in stocks)
            {
                output.Append(string.Format("** {0} **", stock.Symbol));
                output.Append(string.Format("\n   Site:  '{0}'", stock.Site));
                output.Append(string.Format("\n   Data source:\t'{0}'", stock.DataSource));
                output.Append(string.Format(culture, "\n   Data points:\t{0:#,##0}", stock.DataPoints));
                output.Append(string.Format(culture, "\n   Min price:\t\t{0:C}", stock.Min));
                output.Append(string.Format(culture, "\n   Max price:\t{0:C}", stock.Max));
                output.Append(string.Format(culture, "\n   Avg price:\t\t{0:C}\n\n", stock.Avg));
            }
            return output.ToString();
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

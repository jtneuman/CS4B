using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadandWrite.Classes;

namespace ReadandWrite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var success = false;
            txtMessage.Clear();

            if (rbnBinary.Checked)
            {
                byte[] binaryData = { 1, 2, 4, 8, 16, 32, 64, 128 };
                success = IO.WriteToFile(@"C:\Test\binary.bin", DataFormat.Binary, binaryData);
            }
            else if (rbnText.Checked)
            {
                success = IO.WriteToFile(@"C:\Test\text.txt", DataFormat.Text, txtMessage.Text); 
            }

            if (!success) MessageBox.Show("Could not write to the file!");
            

        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            var success = false;
            txtMessage.Clear();

            if (rbnBinary.Checked)
            {
                success = IO.ReadFile(@"C:\Test\binary.bin", DataFormat.Binary, out object binaryData);
            }
            else if (rbnText.Checked)
            {
                success = IO.ReadFile(@"C:\Test\text.txt", DataFormat.Text, out object text);
                if (success) txtMessage.Text = text.ToString();
            }

            if (!success)
                MessageBox.Show("Could not read from the file!");
        }
    }
}

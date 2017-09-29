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

        private void btnSave_Click(object sender, EventArgs e)
        {
            var success = false;

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
            txtMessage.Clear();

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            var success = false;
            txtMessage.Clear();

            if (rbnBinary.Checked)
            {
                object binaryData;
                success = IO.ReadFile(@"C:\Test\binary.bin", DataFormat.Binary, out binaryData);
            }
            else if (rbnText.Checked)
            {
                object text;
                success = IO.ReadFile(@"C:\Test\text.txt", DataFormat.Text, out text);
                if (success) txtMessage.Text = text.ToString();
            }

            if (!success)
                MessageBox.Show("Could not read from the file!");
        }
    }
}

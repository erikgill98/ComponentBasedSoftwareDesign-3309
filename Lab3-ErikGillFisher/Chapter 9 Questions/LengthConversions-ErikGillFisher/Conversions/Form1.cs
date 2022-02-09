using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] conversionTable = {
			{"Miles to kilometers", "Miles", "Kilometers", "1.6093"},
			{"Kilometers to miles", "Kilometers", "Miles", "0.6214"},
			{"Feet to meters", "Feet", "Meters", "0.3048"},
			{"Meters to feet", "Meters", "Feet", "3.2808"},
			{"Inches to centimeters", "Inches", "Centimeters", "2.54"},
			{"Centimeters to inches", "Centimeters", "Inches", "0.3937"}
		};

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboConversions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //displaying what's selected
            if (cboConversions.SelectedIndex == 0)
            {
                lblFromLength.Text = "Miles";
                lblToLength.Text = "Kilometers";
                lblCalculatedLength.Text = "";
                txtLength.Text = "";
            }
            else if (cboConversions.SelectedIndex == 1)
            {
                lblFromLength.Text = "Kilometers";
                lblToLength.Text = "Miles";
                lblCalculatedLength.Text = "";
                txtLength.Text = "";
            }
            else if (cboConversions.SelectedIndex == 2)
            {
                lblFromLength.Text = "Feet";
                lblToLength.Text = "Meters";
                lblCalculatedLength.Text = "";
                txtLength.Text = "";
            }
            else if (cboConversions.SelectedIndex == 3)
            {
                lblFromLength.Text = "Meters";
                lblToLength.Text = "Feet";
                lblCalculatedLength.Text = "";
                txtLength.Text = "";
            }
            else if (cboConversions.SelectedIndex == 4)
            {
                lblFromLength.Text = "Inches";
                lblToLength.Text = "Centimeters";
                lblCalculatedLength.Text = "";
                txtLength.Text = "";
            }
            else if (cboConversions.SelectedIndex == 5)
            {
                lblFromLength.Text = "Centimeters";
                lblToLength.Text = "Inches";
                lblCalculatedLength.Text = "";
                txtLength.Text = "";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double input;
            double output;

            if (double.TryParse(txtLength.Text, out input))
            { 
                //conversion
                output = input * Convert.ToDouble(conversionTable[cboConversions.SelectedIndex, 3]);
                lblCalculatedLength.Text = output.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Error invalid in Input");
                txtLength.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //loop to display the conversions
            for (int i = 0; i < conversionTable.GetLength(0); i++)
            {
                var c = conversionTable[i, 0];
                cboConversions.Items.Add(c);
            }

            cboConversions.SelectedIndex = 0;
        }
    }
}
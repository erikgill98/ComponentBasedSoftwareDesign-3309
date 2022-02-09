using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool IsValidData()
        {
            if (!IsPresent(txtArrivalDate, "Arrival Date"))

                return false;

            if (!IsPresent(txtDepartureDate, "Departure Date"))

                return false;

            if (!IsDateTime(txtArrivalDate, "Arrival Date"))

                return false;

            if (!IsDateTime(txtDepartureDate, "Departure Date"))

                return false;

            if (!IsWithinRange(txtArrivalDate, "Arrival Date", DateTime.Now.Date, DateTime.Now.AddYears(5).Date))

                return false;

            if (!IsWithinRange(txtDepartureDate, "Departure Date", DateTime.Now.Date, DateTime.Now.AddYears(5).Date))

                return false;

            return true;
        }

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

        public bool IsDateTime(TextBox textBox, string name)
        {
            DateTime dateTemp;

            if (!DateTime.TryParseExact(textBox.Text, "MM/dd/yyyy", new System.Globalization.CultureInfo("en-US"), System.Globalization.DateTimeStyles.None, out dateTemp))

            {
                MessageBox.Show(name + " Should be a valid date with valid format.", "Invalid date Error");
                textBox.Focus();
                return false;

            }

            return true;
        }

        public bool IsWithinRange(TextBox textBox, string name,
            DateTime min, DateTime max)
        {
            DateTime tempD = DateTime.Parse(textBox.Text, new System.Globalization.CultureInfo("en-US")).Date;

            if (tempD.Date < min.Date || tempD.Date > max.Date)

            {

                MessageBox.Show(name + " Should be within the rage of 5 years from the curent date.", "Date Range Error");

                textBox.Focus();

                return false;
            }

            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //creating variables for arrival and departure dates
            DateTime arriveDate = DateTime.Parse(txtArrivalDate.Text, new System.Globalization.CultureInfo("en-US"));
            DateTime departDate = DateTime.Parse(txtDepartureDate.Text, new System.Globalization.CultureInfo("en-US"));

            //calculating time spent
            TimeSpan timeThere = departDate.Subtract(arriveDate);
            int night = (int)timeThere.TotalDays;
            txtNights.Text = Convert.ToString(night);

            //creating price and count variables for while 
            decimal price = 0;
            int count = 0;

            //while loop to check days
            while (count < night)
            {
                DateTime tempyDay = arriveDate.AddDays(count);
                DayOfWeek dayWeek = tempyDay.DayOfWeek;

                string stringweek = dayWeek.ToString();
                if (stringweek.Equals("Friday") || stringweek.Equals("Saturday"))
                {
                    price += 150;
                }  
                else 
                { 
                    price += 120;
                }
                count++;
            }
            //printing out the prices
            txtTotalPrice.Text = Convert.ToString("$" + price);
            decimal average = price / (int)night;
            txtAvgPrice.Text = Convert.ToString("$" + average);
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //gets current date
            DateTime currentDate = DateTime.Now;
            txtArrivalDate.Text = currentDate.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            //adds 3 das to current date
            DateTime departDate = DateTime.Now.AddDays(3);
            txtDepartureDate.Text = departDate.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

        }
    }
}
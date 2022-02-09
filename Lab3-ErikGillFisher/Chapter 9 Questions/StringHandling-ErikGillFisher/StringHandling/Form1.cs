using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            string userEmail = Convert.ToString(txtEmail.Text);
            userEmail = userEmail.Trim();

            //checking if @
            if (userEmail.Contains("@"))
            {
                //searches through string until @ is found
                int domainAfter = userEmail.IndexOf("@") + 1;

                string usernameAfter = userEmail.Substring(0, domainAfter - 1);
                string name = userEmail.Substring(domainAfter);

                MessageBox.Show("User name: " + usernameAfter + '\n' + "Domain name: " + name, "Parsed String");
            }
            else
            {
                MessageBox.Show("Invaild Email!");
            }

        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            string city = Convert.ToString(txtCity.Text);
            string state = Convert.ToString(txtState.Text);
            decimal zip = Convert.ToDecimal(txtZipCode.Text);

            // created string contecting city, state and zip together
            string address = city + " " + state.ToUpper() + " " + zip;

            MessageBox.Show(" City, " + " State, " + " Zip: " + address, "Formatted String");
        }
    }
}

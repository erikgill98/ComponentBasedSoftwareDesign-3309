using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class CalculateChange : Form
    {
        public CalculateChange()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //setting values to each coin
            int quarter = 25;
            int dime = 10;
            int nickel = 05;
            int penny = 01;

            //converting user input to type int32 -- setting to change
            int Change = Convert.ToInt32(txtChangeDue.Text);

            //multiple checks to see what change is larger than
            if(Change >= quarter)
            {
                //setting quarter text box = to the amount of quarters in user input
                txtQuarter.Text = (Change / quarter).ToString();
                //reducing change with remainder of quarters
                Change = Change % quarter;
            }

            if (Change >= dime)
            {
                txtDime.Text = (Change / dime).ToString();
                Change = Change % dime;
            }

            if (Change >= nickel)
            {
                txtNickel.Text = (Change / nickel).ToString();
                Change = Change % nickel;
            }

            if (Change >= penny)
            {
                txtPenny.Text = (Change / penny).ToString();
                Change = Change % penny;
            }
            //setting focus
            txtChangeDue.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

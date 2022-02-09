using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        //creating constant price for food
        const double Hamburger = 6.95d;
        const double Pizza = 5.95d;
        const double Salad = 4.95d;
        //addon price -- not constant
        double AddOn = 0.00d;

        double AddOnPrice = 0.00d;
        double totalOrder = 0.00d;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearTotals()
        {
            lblOrderTotal.Text = string.Empty;
            lblSubtotal.Text = string.Empty;
            lblSalesTax.Text = string.Empty;
            totalOrder = 0.00d;
        }

        private void ClearAddOn()
        {
            cbxLTO.Checked = false;
            cbxKMM.Checked = false;
            cbxFF.Checked = false;
            AddOn = 0.00d;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            //user clicks main course
            if (rbtnHamb.Checked)
                totalOrder += Hamburger;
            if (rbtnPizza.Checked)
                totalOrder += Pizza;
            if (rbtnSalad.Checked)
                totalOrder += Salad;

            totalOrder += AddOn;
            
            lblSubtotal.Text = "$" + String.Format("{0:0.00}", totalOrder);

            //calculating taxxy
            double tax = (totalOrder * 7.75d) / 100;
            lblSalesTax.Text = "$" + String.Format("{0:0.00}", tax);
            lblOrderTotal.Text = "$" + String.Format("{0:0.00}", (totalOrder + tax));
        }

        private void rbtnHamb_CheckedChanged(object sender, EventArgs e)
        {
            //clearing boxes
            ClearTotals();
            ClearAddOn();
            //button for hamburger checked --- show hamburger toppings 
            if (rbtnHamb.Checked)
            {
                gbxAddOn.Text = "Add-on items ($.75/each)";

                cbxLTO.Text = "Lettuce, tomato and onions";
                cbxKMM.Text = "Ketchup, mustard and mayo";
                cbxFF.Text = "French Fries";
                AddOnPrice = 0.75d;
            }
        }

        private void rbtnPizza_CheckedChanged(object sender, EventArgs e)
        {
            //clearing boxes
            ClearTotals();
            ClearAddOn(); 
            //button for pizza checked --- show pizza toppings
            if (rbtnPizza.Checked)
            {
                gbxAddOn.Text = "Add-on items ($.50/each)";

                cbxLTO.Text = "Pepperoni";
                cbxKMM.Text = "Sausage";
                cbxFF.Text = "Olives";
                AddOnPrice = 0.50d;
            }
        }

        private void rbtnSalad_CheckedChanged(object sender, EventArgs e)
        {
            //clearing boxes
            ClearTotals();
            ClearAddOn();

            //button for salad checked --- show salad toppings
            if (rbtnSalad.Checked)
            {
                gbxAddOn.Text = "Add-on items ($.25/each)";
                cbxLTO.Text = "Croutons";
                cbxKMM.Text = "Bacon Bits";
                cbxFF.Text = "Bread Sticks";
                AddOnPrice = 0.25d;
            }
        }

        private void cbxLTO_CheckedChanged(object sender, EventArgs e)
        {
            //if checked -- adds to total price
            if (cbxLTO.Checked)
                AddOn += AddOnPrice;
            else
                AddOn -= AddOnPrice;

            ClearTotals();
        }

        private void cbxKMM_CheckedChanged(object sender, EventArgs e)
        {
            //if checked -- adds to total price
            if (cbxKMM.Checked)
                AddOn += AddOnPrice;
            else
                AddOn -= AddOnPrice;

            ClearTotals();
        }

        private void cbxFF_CheckedChanged(object sender, EventArgs e)
        {
            //if checked -- adds to total price
            if (cbxFF.Checked)
                AddOn += AddOnPrice;
            else
                AddOn -= AddOnPrice;

            ClearTotals();
        }
    }
}
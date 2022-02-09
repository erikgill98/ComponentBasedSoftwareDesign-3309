using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class TaxInc : Form
    {
        public TaxInc()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal income = Convert.ToDecimal(txtTaxableInc.Text);
            decimal tax;

            //tax bracket 1
            if(income >= 0 && income < 9225)
            {
                //multiplying income by 10%
                tax = income * .10m;
                txtTaxOwed.Text = tax.ToString();
            }

            //tax bracket 2
            if (income >= 9225 && income < 37450)
            {
                //m is for decimal addition
                //subtracting previous tax bracket from income than multiplying by 15%
                tax = 922.50m + (int)((income - 9225) * .15m);
                txtTaxOwed.Text = tax.ToString();
            }

            //tax bracket 3
            if (income >= 37450 && income < 90750)
            {
                tax = 5156.25m + (int)((income - 37450) * .25m);
                txtTaxOwed.Text = tax.ToString();
            }

            //tax bracket 4
            if (income >= 90750 && income < 189300)
            {
                tax = 18481.25m + (int)((income - 90750) * .28m);
                txtTaxOwed.Text = tax.ToString();
            }

            //tax bracket 5
            if (income >= 189300 && income < 411500)
            {
                tax = 46075.25m + (int)((income - 189300) * .33m);
                txtTaxOwed.Text = tax.ToString();
            }

            //tax bracket 6
            if (income >= 411500 && income < 413200)
            {
                tax = 119401.25m + (int)((income - 411500) * .35m);
                txtTaxOwed.Text = tax.ToString();
            }

            //tax bracket 1
            if (income >= 413200)
            {
                tax = 119996.25m + (int)((income - 413200) * .396m);
                txtTaxOwed.Text = tax.ToString();
            }

        }

        private decimal CalculateTax(decimal income)
        {
            decimal tax1 = 0m;

            //tax bracket 1
            if (income >= 0 && income < 9225)
            {
                //multiplying income by 10%
                tax1 = income * .10m;
                txtTaxOwed.Text = tax1.ToString();
            }

            //tax bracket 2
            if (income >= 9225 && income < 37450)
            {
                //m is for decimal addition
                //subtracting previous tax bracket from income than multiplying by 15%
                tax1 = 922.50m + (int)((income - 9225) * .15m);
                txtTaxOwed.Text = tax1.ToString();
            }

            //tax bracket 3
            if (income >= 37450 && income < 90750)
            {
                tax1 = 5156.25m + (int)((income - 37450) * .25m);
                txtTaxOwed.Text = tax1.ToString();
            }

            //tax bracket 4
            if (income >= 90750 && income < 189300)
            {
                tax1 = 18481.25m + (int)((income - 90750) * .28m);
                txtTaxOwed.Text = tax1.ToString();
            }

            //tax bracket 5
            if (income >= 189300 && income < 411500)
            {
                tax1 = 46075.25m + (int)((income - 189300) * .33m);
                txtTaxOwed.Text = tax1.ToString();
            }

            //tax bracket 6
            if (income >= 411500 && income < 413200)
            {
                tax1 = 119401.25m + (int)((income - 411500) * .35m);
                txtTaxOwed.Text = tax1.ToString();
            }

            //tax bracket 1
            if (income >= 413200)
            {
                tax1 = 119996.25m + (int)((income - 413200) * .396m);
                txtTaxOwed.Text = tax1.ToString();
            }
            return tax1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTaxableInc_TextChanged(object sender, EventArgs e)
        {
            //Clears Textbox
            txtTaxOwed.Text = "";
        }
    }
}

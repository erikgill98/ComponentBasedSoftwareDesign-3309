using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class FactorialCalc : Form
    {
        public FactorialCalc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //converting txtNumber to a 64bit int -- setting equal to num
            long num = Convert.ToInt64(txtNumber.Text);
            //starting total at 1
            long total = 1;

            while (num > 0 && num <= 20)
            {
                //setting total = each run through of 1,2,3 etc
                total *= num;
                //decreasing num by 1
                num--;
            }
            //printing number into factorial textbox
            txtFactorial.Text = total.ToString("N0");


            //focusing on number textbox
            txtNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

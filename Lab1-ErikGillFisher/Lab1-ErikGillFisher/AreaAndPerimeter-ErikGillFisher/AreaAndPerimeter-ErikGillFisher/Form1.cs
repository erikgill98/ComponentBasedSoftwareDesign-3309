using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeter_ErikGillFisher
{
    public partial class AreaAndPerimeter : Form
    {
        public AreaAndPerimeter()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //gets the values of length and width into decimal data type
            double length = Convert.ToDouble(txtLength.Text);
            double width = Convert.ToDouble(txtWidth.Text);

            //calculates area and perimeter
            double area = length * width;
            double perimeter = 2 * length + 2 * width;

            //displays area and perimeter
            txtArea.Text = Convert.ToString(area);
            txtPerimeter.Text = Convert.ToString(perimeter);

            //sets focus
            txtLength.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }

        private void AreaAndPerimeter_Load(object sender, EventArgs e)
        {
            txtArea.Text = "";
            txtWidth.Text = "";
            txtLength.Text = "";
            txtPerimeter.Text = "";
        }
    }
}

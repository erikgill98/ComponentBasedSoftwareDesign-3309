using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0_ErikGillFisher
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!");

            MessageBox.Show("Hello, " + txtFirstName.Text + " " + txtLastName.Text + 
                ". You are " + txtAge.Text + ".");

            int age = Int32.Parse(txtAge.Text);

            if (age < 35)
                MessageBox.Show("You are young.");
            else if (age < 55)
                MessageBox.Show("You are middle aged.");
            else
                MessageBox.Show("Prepare for retirement!");

            for (int i = 0; i < 3; i++)
                MessageBox.Show("i = " + i.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

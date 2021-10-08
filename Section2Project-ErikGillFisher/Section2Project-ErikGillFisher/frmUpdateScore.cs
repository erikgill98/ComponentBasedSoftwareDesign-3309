using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Section2Project_ErikGillFisher
{
	public partial class frmUpdateScore : Form
	{

		public frmUpdateScore()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			//closing form
			this.Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				//converting textbox to type int32
				int u = Convert.ToInt32(txtUpdateScore.Text);
				//check to see if score is fine
				if (u >= 0 && u <= 100)
                {
					//setting tag to that score
					Tag = u;
					DialogResult = DialogResult.OK;
					this.Close();
                }
                else
                {
					//if not in right format error message shows
					MessageBox.Show("Please enter a score between 0 and 100");
                }
			}
			catch (FormatException)
			{
				//catches error as well like decimal/etc
				MessageBox.Show("Enter a valid score.");
			}
		}

        private void frmUpdateScore_Load(object sender, EventArgs e)
        {
			//setting the textbox equal to the tag so it fills form with info
			txtUpdateScore.Text = Tag.ToString();
			txtUpdateScore.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Section2Project_ErikGillFisher
{
    public partial class frmAddScore : Form
    {

		private int addScore;
		//private List<int> scoreList;

		public frmAddScore()
		{
			InitializeComponent();
			txtScore.Focus();
		}


		private void btnCancel_Click(object sender, EventArgs e)
		{
			//closes form
			this.Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				addScore = Convert.ToInt32(txtScore.Text);
				//checking if score is valid
				if (addScore >= 0 && addScore <= 100)
				{
					Tag = addScore;
					DialogResult = DialogResult.OK;
					
					this.Close();
				}
				else
				{
					MessageBox.Show("Enter a score between 0 and 100.");
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("Enter a valid score!");
			}
		}
	}
}

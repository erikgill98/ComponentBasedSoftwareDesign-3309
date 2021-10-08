using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Section2Project_ErikGillFisher
{
    public partial class frmAddNewStudent : Form
    {
		//temp list for newly added student
		List<int> tempList = new List<int>();

		public frmAddNewStudent()
        {
			InitializeComponent();
		}


		private void btnOK_Click(object sender, EventArgs e)
		{
			//checks if name textbox is empty
			if (txtName.Text != "")
            {
				//adds name to student class
				Student newStudent = new Student(Convert.ToString(txtName.Text), tempList);
				Tag = newStudent;
				DialogResult = DialogResult.OK;
				this.Close();
			}
			else
            {
				//if no name --> displays this
				MessageBox.Show("Please Enter a Name!");
			}
		}

		private void btnAddScores_Click(object sender, EventArgs e)
		{
			try
			{
				//new int testScore --> converting txtScore to type int32
				int testScore = Convert.ToInt32(txtScore.Text);

				//check to see if score is correct 
				if(testScore >= 0 && testScore <= 100)
				{
                    tempList.Add(testScore);
					txtAllScore.Text = string.Join(", ", tempList);
					txtScore.Clear();
					txtScore.Focus();
				}
				//displays error message if not
				else
				{
					MessageBox.Show("Please enter a score between 0 and 100.");
					txtScore.Focus();
				}
			}
			//catch incase format is completetly wrong
			catch (FormatException)
			{
				MessageBox.Show("Please enter a valid number");
				txtScore.Focus();
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			//clears all textboxs and list
			txtAllScore.Text = "";
			tempList.Clear();
			txtScore.Text = "";
			txtScore.Focus();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			//closes form
			this.Close();
		}
    }
}

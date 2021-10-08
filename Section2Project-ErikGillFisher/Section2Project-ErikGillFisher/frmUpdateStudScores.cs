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
	public partial class frmUpdateStudScores : Form
	{
		//list for updated student
		List<int> tempUpdated = new List<int>();

		public frmUpdateStudScores()
		{
			InitializeComponent();
		}

		private void frmUpdateStudScores_Load(object sender, EventArgs e)
		{
			//setting tag to s
			Student s = (Student)Tag;
			txtName.Text = s.name;

			for(int i = 0; i < s.scores.Count; i++)
            {
				lstBScore.Items.Add(s.scores[i]);
				tempUpdated.Add(s.scores[i]);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			//closes form
			this.Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			//opening add form
			Form addScore = new frmAddScore();
			addScore.ShowDialog();

			if(addScore.DialogResult == DialogResult.OK)
            {
				//adding the new score to the listbox
				int addedScore = (int)addScore.Tag;
				lstBScore.Items.Add(addedScore);
				tempUpdated.Add(addedScore);
            }
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			//creating selected variable
			int selected = lstBScore.SelectedIndex;
			Form updateScore = new frmUpdateScore();

			//checking if something is selected
			if(selected != -1)
            {
				//updating tag
				updateScore.Tag = tempUpdated[selected];
				updateScore.ShowDialog();

				//creating a new int var equal to tag
				int newScore = (int)updateScore.Tag;
				//removing selected index
				lstBScore.Items.RemoveAt(selected);
				//inserting new score
				lstBScore.Items.Insert(selected, newScore);
				tempUpdated[selected] = newScore;
            }
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Student s = new Student(txtName.Text, tempUpdated);
			Tag = s;
			DialogResult = DialogResult.OK;
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			//creating selected index
			int selected = lstBScore.SelectedIndex;

			//removing selected code
			lstBScore.Items.RemoveAt(selected);
			tempUpdated.RemoveAt(selected);
		}

        private void btnClear_Click_1(object sender, EventArgs e)
        {
			//clears list box and my temp list
			lstBScore.Items.Clear();
			tempUpdated.Clear();
		}
    }
}

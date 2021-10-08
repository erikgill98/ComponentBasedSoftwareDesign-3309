using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section2Project_ErikGillFisher
{
	public partial class frmStudentScores : Form
	{
		//creating new list called studentList
		List<Student> studentList = new List<Student>();

		public frmStudentScores()
		{
			InitializeComponent();
		}

		private void frmStudentScores_Load(object sender, EventArgs e)
		{

			//string to store name
			string n1 = "Joel Murach";

			//list to store scores for joel
			List<int> s1 = new List<int>();
			s1.Add(97);
			s1.Add(71);
			s1.Add(83);

			//string to store name
			string n2 = "Doug Lowe";

			//list to store scores for doug
			List<int> s2 = new List<int>();
			s2.Add(99);
			s2.Add(93);
			s2.Add(97);

			//string to store name
			string n3 = "Glenn Howerton";

			//list to store scores for glenn
			List<int> s3 = new List<int>();
			s3.Add(100);
			s3.Add(100);
			s3.Add(100);

			//calling class -- adding to listbox
			Student ex1 = new Student(n1, s1);
			Student ex2 = new Student(n2, s2);
			Student ex3 = new Student(n3, s3);
			studentList.Add(ex1);
			studentList.Add(ex2);
			studentList.Add(ex3);
			lstbStudents.Items.Add(displayList(ex1));
			lstbStudents.Items.Add(displayList(ex2));
			lstbStudents.Items.Add(displayList(ex3));
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			//exits app
			this.Close();
		}
		
		private void btnAddNew_Click(object sender, EventArgs e)
		{
			//opening addnewstudent form
			Form addNew = new frmAddNewStudent();
			addNew.ShowDialog();

			if(addNew.DialogResult == DialogResult.OK)
            {
				Student s = (Student)addNew.Tag;
				studentList.Add(s);
				//calls my displayList function to add items to listbox
				lstbStudents.Items.Add(displayList(s));
            }
            else
            {
				return;
            }
		}

		private string displayList(Student s)
        {
			//making string builder to run through names
			StringBuilder stringy = new StringBuilder();
			stringy.Append(s.name);
			stringy.Append(" | ");
			//seperating the scores with |
			stringy.Append(string.Join(" | ", s.scores));

			return stringy.ToString();
		}
	
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			//creating a selected variable 
			int selected = lstbStudents.SelectedIndex;
			//opening update student scores
			Form updateForm = new frmUpdateStudScores();

			//checking if something is selected
			if(selected != -1)
            {
				//setting tag to the selected index
				updateForm.Tag = studentList[selected];
				updateForm.ShowDialog();
				//calling student class, named s, going to update form
				Student s = (Student)updateForm.Tag;
				//removing old score
				studentList.RemoveAt(selected);
				//inserting new one
				studentList.Insert(selected, s);
				lstbStudents.Items.RemoveAt(selected);
				lstbStudents.Items.Insert(selected, displayList(s));
			}
		}


		private void btnDelete_Click(object sender, EventArgs e)
		{
			//creating a selected variable 
			int selected = lstbStudents.SelectedIndex;

			//checking if something is selected
			if(selected != -1)
            {
				//removing it from listbox and student list
				lstbStudents.Items.RemoveAt(selected);
				studentList.RemoveAt(selected);
            }
		}

        private void lstbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
			if(lstbStudents.SelectedIndex == -1)
            {
				return;
            }
            else 
			{
				//creating a selected variable 
				int selected = lstbStudents.SelectedIndex;
				//new list equal to selected variable from studentList
				List<int> scoreScorey = studentList[selected].scores;
				//counting numbers in student list
				int TommyTa = studentList[selected].scores.Count;
				//creating total variable
				int total = 0;
				//loop to run through int tommyTA
				for (int i = 0; i < TommyTa; i++)
					{
						//getting total
						total += scoreScorey[i];
					}
				//getting count
				int count = scoreScorey.Count;
				//checking if count isn't 0
				if (count != 0)
				{
					//getting average
					int avg = total / count;
					//putting values in textbox
					txtAverage.Text = avg.ToString();
					txtTotalScore.Text = total.ToString();
					txtScoreCount.Text = count.ToString();
				}
			 }
        }
    }
}

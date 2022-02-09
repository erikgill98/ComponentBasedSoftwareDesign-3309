using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int total = 0;
        int count = 0;

        //creates array
        int[] arrayScores = new int[20];

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(txtScore.Text);
            //adding scores to array
            arrayScores[count] = score; 

            total += score;
            count += 1;
            int average = total / count;
            txtScoreTotal.Text = total.ToString();
            txtScoreCount.Text = count.ToString();
            txtAverage.Text = average.ToString();
            txtScore.Focus();

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            total = 0;
            count = 0;
            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";
            txtScore.Focus();
            //clears array
            arrayScores = new int[20];

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //sorting array
            Array.Sort(arrayScores);
            string totalString = "";
            //displaying array in message box
            for(int i = 0; i < arrayScores.Length; i++)
            {
                //removes 0 values from array
                if(arrayScores[i] > 0)
                {
                totalString += arrayScores[i] + "\n";        
                }
            }
            MessageBox.Show("The array of scores are:" + "\n" + totalString);
        }
    }
}
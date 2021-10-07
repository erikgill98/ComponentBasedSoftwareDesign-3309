using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator_ErikGillFisher
{
    public partial class ScoreCalculator : Form
    {
        //creating variables
        int score = 0;
        int scoreTotal = 0;
        double avgScore = 0;
        int count;
        public ScoreCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            score = int.Parse(txtScore.Text);
            count++; //increases count
            scoreTotal += score; //gets total score
            avgScore = score / count; //averages scores
            //display results
            txtScoreTotal.Text = Convert.ToString(scoreTotal);
            txtScoreCount.Text = Convert.ToString(count);
            txtAvg.Text = Convert.ToString(avgScore);
            //focus and clear score input
            txtScore.Clear();
            txtScore.Focus();
        }

        private void txtAvg_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            txtScore.Clear();
            txtScoreCount.Clear();
            txtAvg.Clear();
            txtScoreTotal.Clear();
            txtScore.Clear();
            txtScore.Focus();
            avgScore = 0;
            scoreTotal = 0;
            count = 0;
        }
    }
}

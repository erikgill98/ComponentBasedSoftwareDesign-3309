using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix2
{
    public partial class Form1 : Form
    {
        //creating matrix variables
        private Matrix matrixA;
        private Matrix matrixB;
        private Matrix matrixC;

        public Form1()
        {
            InitializeComponent();
            rBtnMult.Checked = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMakeB_Click(object sender, EventArgs e)
        {
            try
            {
                //creating new matrix
                matrixB = new Matrix(Convert.ToInt32(txtRowsB.Text), Convert.ToInt32(txtColsB.Text));
                //populating with random
                matrixB.populateRandom();
                //running new matrix through to string
                txtMatrixB.Text = matrixB.ToString();
            }
            catch
            {
                //if not compatible error shows
                MessageBox.Show("Error. Please enter valid data");
            }
        }
        private void btnMakeA_Click(object sender, EventArgs e)
        {
            try
            {
                //creating new matrix
                matrixA = new Matrix(Convert.ToInt32(txtRowsA.Text), Convert.ToInt32(txtColsA.Text));
                //populating with random
                matrixA.populateRandom();
                //running new matrix through to string
                txtMatrixA.Text = matrixA.ToString();
            }
            catch
            {
                //if not compatible error shows
                MessageBox.Show("Error. Please enter valid data");
            }
        }
        private void btnMakeBIden_Click(object sender, EventArgs e)
        {
            int num = 0;
            try
            {
                if (txtRowsB.Text == txtColsB.Text && txtColsB.Text != "")
                {
                    num = int.Parse(txtColsB.Text);
                }
                matrixB = Matrix.MakeID(num);
                txtMatrixB.Text = matrixB.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.GetType());
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (rBtnMult.Checked)
                {
                    matrixC = matrixA * matrixB;
                    txtMatrixC.Text = matrixC.ToString();
                }
                else if (rBtnAdd.Checked)
                {
                    matrixC = matrixA + matrixB;
                    txtMatrixC.Text = matrixC.ToString();
                }
                else if (rBtnSubtract.Checked)
                {
                    matrixC = matrixA - matrixB;
                    txtMatrixC.Text = matrixC.ToString();
                }
                else if (rBtnEquals.Checked)
                {
                    txtMatrixC.Text = "";
                    if (matrixA == matrixB)
                    {
                        txtMatrixC.Text = "A is equal to B";
                    }
                    else
                    {
                        txtMatrixC.Text = "A is not equal to B";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Calculation error: \r\n" + ex.ToString());
            }
        }
        private void btnClearMatrices_Click(object sender, EventArgs e)
        {
            matrixA = null;
            matrixB = null;
            matrixC = null;
            txtMatrixA.Text = "";
            txtMatrixB.Text = "";
            txtMatrixC.Text = "";
        }
        private void btnMakeBCopyA_Click(object sender, EventArgs e)
        {
            if (!object.Equals(matrixA, null))
            {
                matrixB = matrixA.Clone();
                txtMatrixB.Text = matrixB.ToString();
            }
            else
            {
                MessageBox.Show("Matrix A is null");
            }
        }
    }
}

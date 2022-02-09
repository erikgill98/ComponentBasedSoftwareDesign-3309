using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrixOps
{
    public partial class frmMatrixOps : Form
    {
        //making 2d arrays to store matrix
        public double[,] matrixA;
        public double[,] matrixB;
        public double[,] matrixC;

        public frmMatrixOps()
        {
            InitializeComponent();
        }

        //making a 2d array matrix
        public double[,] MakeMatrix(TextBox rows, TextBox cols)
        {
            //converting textboxs to ints
            double[,] tempMatrix = new double[Convert.ToInt32(rows.Text), Convert.ToInt32(cols.Text)];
            //random numbers
            Random random = new Random();

            //for loop to fill rows
            for(int i = 0; i < tempMatrix.GetLength(0); i++)
            {
                //for loop to fill cols
                for(int j = 0; j < tempMatrix.GetLength(1); j++)
                {
                    //filling the matrix with the random numbers from autoRand
                    tempMatrix[i, j] = random.NextDouble() * 10.0;
                }
            }
            return tempMatrix;
        }

        //to string method
        public string matrixToString(double[,] tempMatrix)
        {
            //string variable 
            string s = "";
            //goes through rows
            for(int i = 0; i < tempMatrix.GetLength(0); i++)
            {
                //goes through cols
                for(int j = 0; j < tempMatrix.GetLength(1); j++)
                {
                    //converts each variable tostring
                    s = s + tempMatrix[i, j].ToString("F1") + "\t";
                }
                s += Environment.NewLine;
            }

            return s;

        }
        
        //make A button
        private void btnMakeA_Click(object sender, EventArgs e)
        {
            try
            {
                //running array through matrix function
                matrixA = MakeMatrix(txtRowsA, txtColsA);
                //running array through tostring method
                txtMatrixA.Text = matrixToString(matrixA);
            }
            catch
            {
                //if not compatible error shows
                MessageBox.Show("Error. Please enter valid data");
            }

        }

        //make B button
        private void btnMakeB_Click(object sender, EventArgs e)
        {
            try
            {
                //running array through matrix function
                matrixB = MakeMatrix(txtRowsB, txtColsB);
                //running array through tostring method
                txtMatrixB.Text = matrixToString(matrixB);
            }
            catch
            {
                //if not compatible error shows
                MessageBox.Show("Error. Please enter valid data");
            }
        }

        //exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

                //text changed functions to try and convert to int32
                private void txtRowsA_TextChanged(object sender, EventArgs e)
                        {
                            convertToInt(txtRowsA.Text);
                            txtRowsA.Focus();
                        }

                private void txtColsA_TextChanged(object sender, EventArgs e)
                {
                    convertToInt(txtColsA.Text);
                    txtColsA.Focus();
                }

                private void txtRowsB_TextChanged(object sender, EventArgs e)
                {
                    convertToInt(txtRowsB.Text);
                    txtRowsB.Focus();
                }

                private void txtColsB_TextChanged(object sender, EventArgs e)
                {
                    convertToInt(txtColsB.Text);
                    txtColsB.Focus();
                }

                public void convertToInt(string s)
                {
                    //try to convert variable to int
                    try { Convert.ToInt32(s); }
                    
                    //if can't throws message
                    catch { MessageBox.Show("Cannot convert to int32! Enter valid data", "Error"); }
                }
                //end text change functions
        
        //ID button
        private void btnMakeBIden_Click(object sender, EventArgs e)
        {
            //checks if matrix b is null to prevent program from breaking
            if (matrixB != null)
            {
                //checks if making ID is valid
                if(matrixB.GetLength(0) != matrixB.GetLength(1))
                {
                    MessageBox.Show("Cannot make matrix", "not equal");
                    return;
                }
                //for loop to go through rows
                for (int i = 0; i < matrixB.GetLength(0); i++)
                {
                    //goes through cols
                    for (int j = 0; j < matrixB.GetLength(1); j++)
                    {
                        //checks if row and col are equal to change to 1
                        if (i == j) { matrixB[i, j] = 1.00; }
                        //checks if row and col are equal to change to 0
                        else { matrixB[i, j] = 0.00; }
                    }
                }
                //setting textbook through to string method
                txtMatrixB.Text = matrixToString(matrixB);
            }
        }

        //clear button
        private void btnClearMatrices_Click(object sender, EventArgs e)
        {
            //reset textboxs to 3 to prevent my textbox validator from running
            txtColsA.Text = "3";
            txtColsB.Text = "3";
            txtRowsA.Text = "3";
            txtColsB.Text = "3";

            //clears text boxs
            txtMatrixA.Text = null;
            txtMatrixB.Text = null;
            txtMatrixC.Text = null;

            //clears matrix
            matrixA = null;
            matrixB = null;
            matrixC = null;
        }

        //calculate button
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //checking if matrix can do math
            if (matrixA != null && matrixB != null)
            {
                //checking if mult is checked
                if (rBtnMult.Checked)
                {
                    if (matrixA.GetLength(0) == matrixB.GetLength(1) && matrixA.GetLength(1) == matrixB.GetLength(0))
                    {
                        //calls mult
                        mult();
                        //runs matrix C through to string
                        txtMatrixC.Text = matrixToString(matrixC);
                    }
                    else
                    {
                        MessageBox.Show("Check dimensions of A and B matrix", "Error");
                    }
                }
                //checking if add is checked
                else if (rBtnAdd.Checked)
                {
                    if (matrixA.GetLength(0) == matrixB.GetLength(0) && matrixA.GetLength(1) == matrixB.GetLength(1))
                    {
                        //calls add
                        add();
                        //runs matrix C through to string
                        txtMatrixC.Text = matrixToString(matrixC);
                    }
                    else
                    {
                        MessageBox.Show("Dimensions of A and B matrix must be equal", "Error");
                    }
                }
                //checking if subtract is checked
                else if (rBtnSubtract.Checked)
                {
                    if (matrixA.GetLength(0) == matrixB.GetLength(0) && matrixA.GetLength(1) == matrixB.GetLength(1))
                    {
                        //calls subtract
                        subtract();
                        //runs matrix C through to string
                        txtMatrixC.Text = matrixToString(matrixC);
                    }
                    else
                    {
                        MessageBox.Show("Dimensions of A and B matrices must be equal", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Please initialize A and B matrix.", "Warning");
                }
            }
        }

        //math functions
        public void mult()
        {
            //creating variables to set Matrix A and B 
            int ArowLen = matrixA.GetLength(0);
            int AcolLen = matrixA.GetLength(1);
            int BcolLen = matrixB.GetLength(1);

            matrixC = new double[ArowLen, BcolLen];

            //loops to run through rows and cols
            for(int i = 0; i < ArowLen; i++)
            {
                for(int j = 0; j < BcolLen; j++)
                {
                    for(int k = 0; k < AcolLen; k++)
                    {
                        //multiplication happens here
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

        }

        public void add()
        {
            //creating variables to set Matrix A and B 
            int Alen1 = matrixA.GetLength(0);
            int Alen2 = matrixA.GetLength(1);

            //setting matrix C to the size of A row col
            matrixC = new double[Alen1, Alen2];

            //loops to run through rows and cols
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for(int j = 0; j < matrixA.GetLength(1); j++)
                {
                    //addition happens here
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
        }

        public void subtract()
        {
            //creating variables to set Matrix A and B
            int Alen1 = matrixA.GetLength(0);
            int Alen2 = matrixA.GetLength(1);

            matrixC = new double[Alen1, Alen2];

            for (int i = 0; i < Alen1; i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    //subtraction happens here
                    matrixC[i, j] = matrixA[i, j] -matrixB[i, j];
                }
            }
        }

    }
}

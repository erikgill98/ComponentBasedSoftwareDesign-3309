using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix2
{
    class Matrix
    {
        double[,] matrix;

        public Matrix(int rows, int cols)
        {
            matrix = new double[rows, cols];
        }
        public int Cols
        {
            get { return matrix.GetLength(1); }
        }
        public int Rows
        {
            get { return matrix.GetLength(0); }
        }
        public double this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }
        public bool rowsEqual(Matrix m)
        {
            if (m.Rows != Rows){ return false; }
            return true;
        }
        public bool colsEqual(Matrix m)
        {
            if(m.Cols != Cols){ return false; }
            return true;
        }
        public bool dimsEqual(Matrix m)
        {
            if(m.Rows != Rows && m.Cols != Cols){ return false; }
            return true;
        }
        public Matrix Add(Matrix m)
        {
            if (object.Equals(m, null)){ throw new ArgumentNullException("Matrix is Null!"); }

            if (!dimsEqual(m)) { throw new ArgumentNullException("Dimensions don't Match!"); }

            //creating add matrix
            Matrix addMatrix = new Matrix(Rows, Cols);
            //loop to run through matrix
            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    addMatrix[i, j] = this[i, j] + m[i, j];
                }
            }
            return addMatrix;
        }
        public Matrix Subtract(Matrix m)
        {
            if (object.Equals(m, null))
            {
                throw new ArgumentNullException("Matrix is Null!");
            }
            if (!dimsEqual(m))
            {
                throw new ArgumentNullException("Dimensions don't Match!");
            }
            //creating subtract Matrix
            Matrix subMatrix = new Matrix(Rows, Cols);
            //loop to run through matrix
            for (int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    subMatrix[i, j] = this[i, j] - m[i, j];
                }
            }
            return subMatrix;
        }
        public Matrix Multiply(Matrix m)
        {
            /*
            if (object.Equals(m, null))
            {
                throw new ArgumentNullException("Matrix is null");
            }
            if (!dimsEqual(m))
            {
                throw new ArgumentException("Dimensions don't match");
            }
            */
            //creating multiply matrix
            Matrix multMatrix = new Matrix(this.Rows, Cols);
            //loop to go through matrix
            for(int i = 0; i < this.Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    for(int k = 0; k < this.Rows; k++)
                    {
                        multMatrix[i, j] += this[i, k] * m[k,j];
                    }
                }
            }
            return multMatrix;
        }
        public void populateRandom()
        {
            //creating new random variable
            Random rand = new Random();
            //forloop to go through matrix
            for(int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    //populating matrix
                    matrix[i, j] = rand.NextDouble() * 10.0;
                }
            }
        }
        public override string ToString()
        {
            string text = "";
            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    text += matrix[i, j].ToString("F1") + "\t";
                }
                text += "\r\n";
            }
        return text;
        }
        public override bool Equals(object obj)
        {
            //checks if null
            if(obj == null)
            {
                return false;
            }
            //creating equalsMatrix
            Matrix equalsMatrix = (Matrix)obj;
            //checks if the rows and cols aren't equal
            if(!rowsEqual(equalsMatrix) || !colsEqual(equalsMatrix))
            {
                return false;
            }
            //loop to run through matrix
            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    //if the matrix isn't equal
                    if (equalsMatrix[i, j] != this.matrix[i, j])
                        return false;
                }
            }
            return true;
        }
        public override int GetHashCode()
        {
            //uses sum for has code
            return Sum().GetHashCode(); //double overrides this too
        }
        public double Sum()
        {
            //double variable to store sum
            double x = 0.0;
            //for loop to run through matrix
            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    //setting x equal to matrix
                    x += matrix[i, j];
                }
            }
            return x;
        }
        public static Matrix MakeID(int m)
        {
            //creating id matrix
            Matrix IDmatrix = new Matrix(m, m);
            //runs through rows
            for(int i = 0; i < IDmatrix.Rows; i++)
            {
                //runs through cols
                for(int j = 0; j < IDmatrix.Cols; j++)
                {
                    //checks if row and col are equal to change to 1
                    if (i == j) { IDmatrix[i, j] = 1.0; }
                    //checks if row and col are equal to change to 0
                    else { IDmatrix[i, j] = 0.0; }
                }
            }
            //returns IDmatrix
            return IDmatrix;
        }
        public Matrix Clone()
        {
            //creating clone matrix
            Matrix cloneMatrix = new Matrix(Rows, Cols);
            
            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    //setting clone matrix = to matrix
                    cloneMatrix[i, j] = this.matrix[i, j];
                }
            }
            //returning clone
            return cloneMatrix;
        }
        public void populateOrd()
        {
            //creating popNum variable
            double popNum = 1.0;
            
            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Cols; j++)
                {
                    matrix[i, j] = popNum;
                    popNum += 1.0;
                }
            }
        }
        public static bool operator !=(Matrix mat1, Matrix mat2)
        {
            //checks if they aren't equal
            return !(mat1 == mat2);
        }
        public static bool operator == (Matrix mat1, Matrix mat2)
        {
            if (object.Equals(mat1, null))
            {
                if (object.Equals(mat2, null))
                {
                    return true;
                }
                return false;
            }
            return mat1.Equals(mat2);
        }
        public static Matrix operator - (Matrix mat1, Matrix mat2)
        {
            //checking if any nulls
            if (object.Equals(mat1, null) || object.Equals(mat2, null))
            {
                //throws null argue if they are
                throw new ArgumentNullException("One or both vectors are null");
            }
            //checking if subtract can happen
            if (!mat1.dimsEqual(mat2))
            {
                //throws argument if they can't
                throw new ArgumentException("Dinensions don't match");
            }
            //runs subtract if both if statments fail
            return mat1.Subtract(mat2);
        }
        public static Matrix operator * (Matrix mat1, Matrix mat2)
        {
            //checking if any nulls
            if (object.Equals(mat1, null) || object.Equals(mat2, null))
            {
                //throws null argue if they are
                throw new ArgumentNullException("One or both matrices are empty");
            }
            //checking if mult can happen
            if (mat1.Rows != mat2.Cols || mat1.Cols != mat2.Rows)
            {
                //throws argument if they can't
                throw new ArgumentException("Dimension's do not work for multiplication");
            }
            //runs mult if both if statments fail
            return mat1.Multiply(mat2);
        }
        public static Matrix operator + (Matrix mat1, Matrix mat2)
        {
            //checking if any nulls
            if (object.Equals(mat1, null) || object.Equals(mat2, null))
            {
                //throws null argue if they are
                throw new ArgumentNullException("One or both matrices are empty");
            }
            //checking if addition can happen
            if (!mat1.dimsEqual(mat2))
            {
                //throws argument if they can't
                throw new ArgumentException("Dimensions do not match!");
            }
            //runs add if both if statments fail
            return mat1.Add(mat2);
        }

    }
}

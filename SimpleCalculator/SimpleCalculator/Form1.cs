using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private decimal SimpleCalc(decimal operand1, string operator1, decimal operand2)
        {
            decimal ans = 0;
            if (IsValidData(operand1, operator1, operand2))
            {
                if (operator1 == "/")
                {
                    ans = operand1 / operand2;
                }
                if (operator1 == "*" || operator1 == "x")
                {
                    ans = operand1 * operand2;
                }
                if (operator1 == "+")
                {
                    ans = operand1 + operand2;
                }
                if (operator1 == "-")
                {
                    ans = operand1 - operand2;
                }

                return ans;
            }
            else
            {
                return -1;
            }

            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
                String op = txtOperator.Text;
                decimal operand2 = Convert.ToDecimal(txtOperand2.Text);

                if (IsValidData(operand1, op, operand2))
                {


                    decimal newResult = SimpleCalc(operand1, op, operand2);
                    newResult = Math.Round(newResult, 2);

                    txtResult.Text = newResult.ToString();

                    txtOperand1.Focus();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.GetType().ToString() + ex.StackTrace);
            }
            
    
                      /*   try
                        {

                        }
                        //7-1 work
                       
                        catch(FormatException ex)
                        {
                            MessageBox.Show("Operand must be a number. Try Again.");
                        }
                        catch (OverflowException ex)
                        {
                            MessageBox.Show("Operator is too big. Try Again.");
                        }
                        catch (DivideByZeroException ex)
                        {
                            MessageBox.Show("Divide by zero Error. Please enter a non-zero for operand 2.");
                        }
                        
                        catch (Exception ex) 
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString() + ex.StackTrace);
                        }
*/
                        //focus
                        txtOperand1.Focus();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
         //   txtOperand1.Text = "";
         //   txtOperator.Text = "";
         //   txtOperand2.Text = "";
        }

        public bool isPresent(TextBox input, string name)
        {
            if(input.Text == "")
            {
                MessageBox.Show("Please enter a value for " + name);
                input.Focus();
                return false;
            }
            return true;
        }

        public bool isDecimal(TextBox input, string name)
        {
            decimal num = 0m;

            if(Decimal.TryParse(input.Text, out num))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value!");
                input.Focus();
                return false;
            }

        }

        public bool isWithinRange(TextBox input, string name, decimal min, decimal max)
        {
            decimal num = Convert.ToDecimal(input.Text);

            if (num < min || num > max)
            {
                MessageBox.Show(name + " must be between" + min + "and " + max);
                input.Focus();
                return false;
            }
            return true;
        }

        public bool isOperator(TextBox input, string name)
        {
            if(input.Text != "+" && input.Text != "-" && input.Text != "/" && input.Text != "*")
            {
                MessageBox.Show("Enter a valid operator: +, -, * or /");
                return false;
            }
            return true;
        }

        public bool IsValidData(decimal operand1, String op, decimal operand2)
        {
            //Checking to see if the user didn't put anything in one of the input boxes
            bool optest1 = isPresent(txtOperand1, "Operand 1");
            bool optest2 = isPresent(txtOperator, "Operator");
            bool optest3 = isPresent(txtOperand2, "Operand 2");

            // if there is input in all of the boxes
            if (optest1 && optest2 && optest3) 
            {
                
                //Checking for valid operands and operators
                if (isDecimal(txtOperand1, "Operand 1") && isOperator(txtOperator, "Operator") && isDecimal(txtOperand2, "Operand 2"))  // here
                {

                    
                    
                    //Checking for valid range
                    if (isWithinRange(txtOperand1, "Operand 2", 0, 1000000) && isWithinRange(txtOperand2, "Operand 2", 0, 1000000))
                    {
                        
                        return true;
                    }
                    
                }
                
            }

            return false;
        }

        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void txtOperator_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void txtOperand2_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class Calculator : Form
    {
        // Variables that will be used in the calculator
        // inputs and operands
        // "Ans" is a double as the value that can be found can be a decimal
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double Ans = 0.0;

        public Calculator()
        {
            // Sets the centre to the centre of the last form
            InitializeComponent();
            CenterToParent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // Erases the last value input from 
            txtEquation.Text = "";
            // "input" to the value (e.g. 1)
            input += "1";
            // Adds what is in the input to the textbox "txtEquation"
            txtEquation.Text += input;
            // Adds "1" to textbox "txtAns"
            txtAns.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtEquation.Text = "";
            input += "2";
            txtEquation.Text += input;
            txtAns.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtEquation.Text = "";
            input += "3";
            txtEquation.Text += input;
            txtAns.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtEquation.Text = "";
            input += "4";
            txtEquation.Text += input;
            txtAns.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtEquation.Text = "";
            input += "5";
            txtEquation.Text += input;
            txtAns.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtEquation.Text = "";
            input += "6";
            txtEquation.Text += input;
            txtAns.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtEquation.Text = "";
            input += "7";
            txtEquation.Text += input;
            txtAns.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtEquation.Text = "";
            input += "8";
            txtEquation.Text += input;
            txtAns.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtEquation.Text = "";
            input += "9";
            txtEquation.Text += input;
            txtAns.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtEquation.Text = "";
            input += "0";
            txtEquation.Text += input;
            txtAns.Text += "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtEquation.Text = "";
            input += ".";
            txtEquation.Text += input;
            txtAns.Text += ".";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Takes what is in the input and gives it to operand1
            operand1 = input;
            // Makes the operation +
            operation = '+';
            // Input becomes empty
            input = string.Empty;
            // Puts the operation + in the textbox "txtAns"
            txtAns.Text += " + ";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
            txtAns.Text += " - ";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
            txtAns.Text += " * ";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
            txtAns.Text += " / ";
        }

        private void btnGetAns_Click(object sender, EventArgs e)
        {
            // Gives what is in input to operand2
            operand2 = input;
            // Creates doubles num 1 and num 2
            double num1, num2;
            // Takes operand1 and operand2's string value, makes them double so that they can be passed into num1 and num2 respectively
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            // If the operation is "+"
            if (operation == '+')
            {
                // Performs addition
                Ans = num1 + num2;
                // Takes "Ans" to the txtEquation's text
                txtEquation.Text = Ans.ToString();
            }
            else if (operation == '-')
            {
                // Performs subtraction
                Ans = num1 - num2;
                txtEquation.Text = Ans.ToString();
            }
            else if (operation == '*')
            {
                // Performs multiplication
                Ans = num1 * num2;
                txtEquation.Text = Ans.ToString();
            }
            else if (operation == '/')
            {
                // If num2 is NOT 0
                if (num2 != 0)
                {
                    // Performs division
                    Ans = num1 / num2;
                    txtEquation.Text = Ans.ToString();
                }
                // If num2 is 0
                else
                {
                    // The division is not performed and an error is displayed
                    txtEquation.Text = "DIV/Zero!";
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears input, both operand1 and operand2, as well as both textboxes "txtEquation" and "txtAns"
            txtEquation.Text = "";
            txtAns.Text = "";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            // Upon load
            MessageBox.Show("This calculator can only handle two numbers being used with ONE function at any ONE time.");
            return;
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            // Takes the string value in "txtEquation" and makes it double, so it can be entered into "root"
            double root = Convert.ToDouble(txtEquation.Text);
            // The value "root" is then square rooted
            root = Math.Sqrt(root);
            // The double "root" is converted to string to be able to enter "txtAns.Text"
            txtAns.Text = Convert.ToString(root);
        }

        private void btnPowers_Click(object sender, EventArgs e)
        {
            // Creates the double "X", and converts "txtEquation.Text" to double so it can be passed onto "X"
            double X = Convert.ToDouble(txtEquation.Text);
            // Creates the double "x", and converts "txtEquation.Text" to double so it can be passed onto "x"
            double x = Convert.ToDouble(txtEquation.Text);

            // Multiplies "X" by "x", then passes the value created into "X"
            X = X * x;
            // Converts "X" into string, so it can be passed into "txtAns.Text"
            txtAns.Text = Convert.ToString(X);
        }
    }
}
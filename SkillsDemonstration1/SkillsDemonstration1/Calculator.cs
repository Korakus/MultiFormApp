using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillsDemonstration1
{
    public partial class Calculator : Form
    {
        //Calculator Application.
        //Global variables
        double first;
        double second;
        double third;
        double answer;
        //calculation
        double calc;
        public Calculator()
        {
            InitializeComponent();
        }
        //Inputs for Digits to calculator
        //Inputs 1 into calculator textBox.
        private void DigitOne_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += "1";
        }
        //Inputs 2 into calculator textBox.
        private void DigitTwo_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += "2";
        }
        //Inputs 3 into calculator textBox.
        private void DigitThree_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += "3";
        }
        //Inputs 4 into calculator textBox.
        private void DigitFour_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += "4";
        }
        //Inputs 5 into calculator textBox.
        private void DigitFive_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += "5";
        }
        //Inputs 6 into calculator textBox.
        private void DigitSix_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += "6";
        }
        //Inputs 7 into calculator textBox.
        private void DigitSeven_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += "7";
        }
        //Inputs 8 into calculator textBox.
        private void DigitEight_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += "8";
        }
        //Inputs 9 into calculator textBox.
        private void DigitNine_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += "9";
        }
        //Inputs 0 into calculator textBox.
        private void DigitZero_Click(object sender, EventArgs e)
        {
            CalculatorTextBox.Text += "0";
        }

        //Inputs for signs into calculator.
        // inputs the + into calculator.
        private void PlusButton_Click(object sender, EventArgs e)
        {
            //Takes the first number made.
            calc = 1;
            first = Convert.ToDouble(CalculatorTextBox.Text);
            //Resets calculatorwith symbol.
            CalculatorTextBox.Text = "+";
        }
        // inputs the - into calculator.
        private void MinusButton_Click(object sender, EventArgs e)
        {
            //Takes first number made.
            calc = 2;
            first = Convert.ToDouble(CalculatorTextBox.Text);
            //Resets calculatorwith symbol.
            CalculatorTextBox.Text = "-";
        }
        // inputs the x into calculator.
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            //Takes the first number made.
            calc = 3;
            first = Convert.ToDouble(CalculatorTextBox.Text);
            //Resets calculatorwith symbol.
            CalculatorTextBox.Text = "x";
        }
        // inputs the ÷ into calculator.
        private void button14_Click(object sender, EventArgs e)
        {
            //Takes the first number made.
            calc = 4;
            first = Convert.ToDouble(CalculatorTextBox.Text);
            //Resets calculatorwith symbol.
            CalculatorTextBox.Text = "÷";
        }
        //Does the Calculation
        private void equalButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Takes the second number made.
                second = Convert.ToDouble(CalculatorTextBox.Text);
            }
            catch
            {
                //If there are no numbers then error msg is shown.
                CalculatorTextBox.Text = "no value";
            }
            if (calc == 1)
            {
                //If symbol was + then it adds the 2 numbers.
                answer = first + second;
                CalculatorTextBox.Text = answer.ToString();
            }
            else if (calc == 2)
            {
                //if symbol was - then it subtracts the 2 numbers.
                answer = first - second;
                CalculatorTextBox.Text = answer.ToString();
            }
            else if (calc == 3)
            {
                //if symbol was x then it multiplies the 2 numbers.
                answer = first * second;
                CalculatorTextBox.Text = answer.ToString();
            }
            else if (calc == 4)
            {
                //if symbol was ÷ then divides the 2 numbers.
                answer = first / second;
                CalculatorTextBox.Text = answer.ToString();
            }
            else
            {
                //if only 1 number input it  leaves the first number.
                answer = first;
                CalculatorTextBox.Text = answer.ToString();
            }
        }

        //Closes the Calculator.
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Opens the About Form.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        //Clears the calculator and refreshes it.
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Sets all values to 0.
            CalculatorTextBox.Text = "";
            first = 0;
            second = 0;
            answer = 0;
        }
    }
}

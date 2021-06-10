using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsForm
{
    public partial class Calculator : Form
    {
        public int firstNumber;
        public int secondNumber;
        public String oper;
        public int result;

        public Calculator()
        {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "1";
            }
            else 
            {
                screen.Text += "1";
            }
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "2";
            }
            else
            {
                screen.Text += "2";
            }
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "3";
            }
            else
            {
                screen.Text += "3";
            }
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "4";
            }
            else
            {
                screen.Text += "4";
            }
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "5";
            }
            else
            {
                screen.Text += "5";
            }
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "6";
            }
            else
            {
                screen.Text += "6";
            }
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "7";
            }
            else
            {
                screen.Text += "7";
            }
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "8";
            }
            else
            {
                screen.Text += "8";
            }
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "9";
            }
            else
            {
                screen.Text += "9";
            }
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (screen.Text == "0")
            {
                screen.Text = "0";
            }
            else
            {
                screen.Text += "0";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            secondNumber = Int32.Parse(screen.Text);
            screen.Clear();

            switch (oper) {
                case "+": 
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                    }
                    else 
                    {
                        MessageBox.Show("You can't divide by 0!");
                        result = 0;
                    }
                    break;
            }            
            screen.Text = result.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            firstNumber = Int32.Parse(screen.Text);
            screen.Clear();
            oper = addButton.Text;
        }

        private void decreaseButton_Click(object sender, EventArgs e)
        {
            firstNumber = Int32.Parse(screen.Text);
            screen.Clear();
            oper = decreaseButton.Text;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            firstNumber = Int32.Parse(screen.Text);
            screen.Clear();
            oper = multiplyButton.Text;
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            firstNumber = Int32.Parse(screen.Text);
            screen.Clear();
            oper = divisionButton.Text;
        }
    }
}

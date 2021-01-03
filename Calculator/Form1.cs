using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class formCalculator : Form
    {
        string input;
        string smallPeriod = ".";
        string expression;
        string operationOne;
        string operationTwo;

        double results;

        public formCalculator()
        {
            InitializeComponent();
        }

        //This function allows the user to press the zero button
        public void btnZero_Click(object sender, EventArgs e)
        {
            input = "0";
            int enteredNumber = Int32.Parse(input);
            txtBoxDisplay.Text += input;
            
        }

        //This function allows the user to press the double button
        public void btnDoubleZeros_Click(object sender, EventArgs e)
        {
            input = "00";
            int enteredNumber = Int32.Parse(input);
            txtBoxDisplay.Text += input;
        }

        //This function allows the user to press the period button
        public void btnPeriod_Click(object sender, EventArgs e)
        {
            txtBoxDisplay.Text += smallPeriod;
        }

        //This function allows the user to press the one button
        public void btnOne_Click(object sender, EventArgs e)
        {
            input = "1";
            int enteredNumber = Int32.Parse(input);
            txtBoxDisplay.Text += input;
        }

        //This function allows the user to press the two button
        public void btnTwo_Click(object sender, EventArgs e)
        {
            input = "2";
            int enteredNumber = Int32.Parse(input);
            txtBoxDisplay.Text += input;
        }

        //This function allows the user to press the three button
        public void btnThree_Click(object sender, EventArgs e)
        {
            input = "3";
            int enteredNumber = Int32.Parse(input);
            txtBoxDisplay.Text += input;
        }

        //This function allows the user to press the four button
        public void btnFour_Click(object sender, EventArgs e)
        {
            input = "4";
            int enteredNumber = Int32.Parse(input);
            txtBoxDisplay.Text += input;
        }

        //This function allows the user to press the five button
        public void btnFive_Click(object sender, EventArgs e)
        {
            input = "5";
            int enteredNumber = Int32.Parse(input);
            txtBoxDisplay.Text += input;
        }

        //This function allows the user to press the six button
        public void btnSix_Click(object sender, EventArgs e)
        {
            input = "6";
            int enteredNumber = Int32.Parse(input);
            txtBoxDisplay.Text += input;
        }

        //This function allows the user to press the seven button
        public void btnSeven_Click(object sender, EventArgs e)
        {
            input = "7";
            int enteredNumber = Int32.Parse(input);
            txtBoxDisplay.Text += input;
        }

        //This function allows the user to press the eight button
        public void btnEight_Click(object sender, EventArgs e)
        {
            input = "8";
            int enteredNumber = Int32.Parse(input);
            txtBoxDisplay.Text += input;
        }

        //This function allows the user to press the nine button
        public void btnNine_Click(object sender, EventArgs e)
        {
            input = "9";
            int enteredNumber = Int32.Parse(input);
            txtBoxDisplay.Text += input;
        }

        //This function allows the user to press the add button
        public void btnAdd_Click(object sender, EventArgs e)
        {
            expression = "+";
            operationOne = input;
            txtBoxDisplay.Text += input;
        }

        //This function allows the user to press the equal button. Also the switch statement determines which 
        //expression the user selected and it will calculate based on the expression the user selected.
        public void btnEqual_Click(object sender, EventArgs e)
        {
            
            operationTwo = input;

            double firstNumber;
            double secondNumber;

            double.TryParse(operationOne, out firstNumber);
            double.TryParse(operationTwo, out secondNumber);

            
            switch(expression)
            {
                case "+":
                    results = firstNumber + secondNumber;
                    txtBoxDisplay.Text = results.ToString();
                    break;

            }
        }
    }
}

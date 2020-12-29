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
        string firstNumber;
        string secondNumber;
        string smallPeriod = ".";
        string Expression;
        string operationOne;
        string operationTwo;

        string results;

        public formCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void btnZero_Click(object sender, EventArgs e)
        {
            firstNumber = "0";
            int enteredNumber = Int32.Parse(firstNumber);
            txtBoxDisplay.Text += firstNumber;
        }

        public void btnDoubleZeros_Click(object sender, EventArgs e)
        {
            firstNumber = "00";
            int enteredNumber = Int32.Parse(firstNumber);
            txtBoxDisplay.Text += firstNumber;
        }

        public void btnPeriod_Click(object sender, EventArgs e)
        {
            txtBoxDisplay.Text += smallPeriod;
        }

        public void btnOne_Click(object sender, EventArgs e)
        {
            firstNumber = "1";
            int enteredNumber = Int32.Parse(firstNumber);
            txtBoxDisplay.Text += firstNumber;
        }

        public void btnTwo_Click(object sender, EventArgs e)
        {
            firstNumber = "2";
            int enteredNumber = Int32.Parse(firstNumber);
            txtBoxDisplay.Text += firstNumber;
        }

        public void btnThree_Click(object sender, EventArgs e)
        {
            firstNumber = "3";
            int enteredNumber = Int32.Parse(firstNumber);
            txtBoxDisplay.Text += firstNumber;
        }

        public void btnFour_Click(object sender, EventArgs e)
        {
            firstNumber = "4";
            int enteredNumber = Int32.Parse(firstNumber);
            txtBoxDisplay.Text += firstNumber;
        }

        public void btnFive_Click(object sender, EventArgs e)
        {
            firstNumber = "5";
            int enteredNumber = Int32.Parse(firstNumber);
            txtBoxDisplay.Text += firstNumber;
        }

        public void btnSix_Click(object sender, EventArgs e)
        {
            firstNumber = "6";
            int enteredNumber = Int32.Parse(firstNumber);
            txtBoxDisplay.Text += firstNumber;
        }

        public void btnSeven_Click(object sender, EventArgs e)
        {
            firstNumber = "7";
            int enteredNumber = Int32.Parse(firstNumber);
            txtBoxDisplay.Text += firstNumber;
        }

        public void btnEight_Click(object sender, EventArgs e)
        {
            firstNumber = "8";
            int enteredNumber = Int32.Parse(firstNumber);
            txtBoxDisplay.Text += firstNumber;
        }

        public void btnNine_Click(object sender, EventArgs e)
        {
            firstNumber = "9";
            int enteredNumber = Int32.Parse(firstNumber);
            txtBoxDisplay.Text += firstNumber;
        }

       public void btnAdd_Click(object sender, EventArgs e)
        {
            operationOne = firstNumber;
            txtBoxDisplay.Text = operationOne;
            
        }

        public void btnEqual_Click(object sender, EventArgs e)
        {
            operationTwo = secondNumber;
            txtBoxDisplay.Text = operationOne + operationTwo;

            
            txtBoxDisplay.Text = results;
        }
    }
}

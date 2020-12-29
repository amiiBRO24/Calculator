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
        string number;
        string smallPeriod = ".";
        string Expression;
        string operationOne;
        string operationTwo;

        double results;

        public formCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void btnZero_Click(object sender, EventArgs e)
        {
            number = "0";
            int enteredNumber = Int32.Parse(number);
            txtBoxDisplay.Text += number;
        }

        public void btnDoubleZeros_Click(object sender, EventArgs e)
        {
            number = "00";
            int enteredNumber = Int32.Parse(number);
            txtBoxDisplay.Text += number;
        }

        public void btnPeriod_Click(object sender, EventArgs e)
        {
            txtBoxDisplay.Text += smallPeriod;
        }

        public void btnOne_Click(object sender, EventArgs e)
        {
            number = "1";
            int enteredNumber = Int32.Parse(number);
            txtBoxDisplay.Text += number;
        }

        public void btnTwo_Click(object sender, EventArgs e)
        {
            number = "2";
            int enteredNumber = Int32.Parse(number);
            txtBoxDisplay.Text += number;
        }

        public void btnThree_Click(object sender, EventArgs e)
        {
            number = "3";
            int enteredNumber = Int32.Parse(number);
            txtBoxDisplay.Text += number;
        }

        public void btnFour_Click(object sender, EventArgs e)
        {
            number = "4";
            int enteredNumber = Int32.Parse(number);
            txtBoxDisplay.Text += number;
        }

        public void btnFive_Click(object sender, EventArgs e)
        {
            number = "5";
            int enteredNumber = Int32.Parse(number);
            txtBoxDisplay.Text += number;
        }

        public void btnSix_Click(object sender, EventArgs e)
        {
            number = "6";
            int enteredNumber = Int32.Parse(number);
            txtBoxDisplay.Text += number;
        }

        public void btnSeven_Click(object sender, EventArgs e)
        {
            number = "7";
            int enteredNumber = Int32.Parse(number);
            txtBoxDisplay.Text += number;
        }

        public void btnEight_Click(object sender, EventArgs e)
        {
            number = "8";
            int enteredNumber = Int32.Parse(number);
            txtBoxDisplay.Text += number;
        }

        public void btnNine_Click(object sender, EventArgs e)
        {
            number = "9";
            int enteredNumber = Int32.Parse(number);
            txtBoxDisplay.Text += number;
        }

       public void btnAdd_Click(object sender, EventArgs e)
        {
            number += number;
        }

        public void btnEqual_Click(object sender, EventArgs e)
        {
            operationTwo = number;

            double numberOne;
            double numberTwo;

            double.TryParse(operationOne, out numberOne);
            double.TryParse(operationTwo, out numberTwo);

            if(Expression == "+")
            {
                results = numberOne + numberTwo;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool IsPrime (int number)
        {
            if (number <= 1) return false; //1 and 0 are not prime numbers

            for (int i = 2; i * i <= number; i++)
            {
                if (number %i == 0) return false; //checking if the number is divisible by i
            }
            return true; //if no divisors found, it's prime
        }


        private void checkButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int number))
            {
                if(IsPrime(number))
                {
                    outputLabel.Text = "The number " + number + "  is a prime number ";
                }
                else
                {
                    outputLabel.Text = "The number " + number + "  is not a prime number ";
                }
            }

            else
            {
                outputLabel.Text = "Invalid input. Please enter an integer";
            }
        }
    }
}

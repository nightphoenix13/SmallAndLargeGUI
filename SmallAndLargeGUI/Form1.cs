// Written by Zack Rosales
// Introduction to C# Programming ITSE 1430 1001
// Program for page 313, # 13

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallAndLargeGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // local variables
            int[] numbers = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            // getting intput from user
            numbers[0] = Convert.ToInt32(numberTextBox1.Text);
            numbers[1] = Convert.ToInt32(numberTextBox2.Text);
            numbers[2] = Convert.ToInt32(numberTextBox3.Text);
            numbers[3] = Convert.ToInt32(numberTextBox4.Text);
            numbers[4] = Convert.ToInt32(numberTextBox5.Text);
            numbers[5] = Convert.ToInt32(numberTextBox6.Text);
            numbers[6] = Convert.ToInt32(numberTextBox7.Text);
            numbers[7] = Convert.ToInt32(numberTextBox8.Text);
            numbers[8] = Convert.ToInt32(numberTextBox9.Text);
            numbers[9] = Convert.ToInt32(numberTextBox10.Text);

            // calling GetExtremes method
            GetExtremes(numbers);
        }

        private void GetExtremes(int[] numbers)
        {
            // local variables
            int low,
                high;

            // finding lowest value
            low = numbers[0];
            for (int x = 1; x < 10; x++)
            {
                if (numbers[x] < low)
                    low = numbers[x];
            }

            // finding highest value
            high = numbers[0];
            for (int x = 1; x < 10; x++)
            {
                if (numbers[x] > high)
                    high = numbers[x];
            }

            // preparing output labels
            outputLabel1.Text = String.Format("The lowest number is {0}.", low);
            outputLabel2.Text = String.Format("The highest number is {0}.", high);

            // making output labels visible
            outputLabel1.Visible = true;
            outputLabel2.Visible = true;
        }
    }
}

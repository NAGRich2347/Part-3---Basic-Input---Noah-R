using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_3___Basic_Input___Noah_R
{
    public partial class Form1 : Form
    {
        double avgAge;
        double avgHeight;

        double userAge;
        double userHeight;
        string firstName;
        string outSent;

        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            avgAge = 82.52;
            avgHeight = 2.72;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            userAge = Convert.ToDouble(numericUpDown1.Text);

            userHeight = Convert.ToDouble(txtHeight.Text);

            firstName = txtName.Text;

            txtOutput.Text = "Hello there, " + firstName + "." + " " + "Your height is " + userHeight + "m. " + "Your age is" + " " + userAge + ". ";

            txtOutput.Text += "\n";

            txtOutput.Text += "You are " + " " + (avgHeight - userHeight) + "m " + "shorter than the tallest man in the world. ";

            txtOutput.Text += "You are " + (avgAge - userAge) + "years away from the average life expectancy in Canada.";
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

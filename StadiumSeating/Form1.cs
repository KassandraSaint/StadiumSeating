using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadiumSeating
{
    public partial class Form1 : Form
    {
        // Initialize constants
        const decimal CLASS_A_PRICE = 15;
        const decimal CLASS_B_PRICE = 12;
        const decimal CLASS_C_PRICE = 9;

        // Initializing variables to hold calculated values for tickets
        private decimal classA;
        private decimal classB;
        private decimal classC;
        private decimal total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateRevenueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Trying to read user's input and convert it to a decimal from a string
                // Storing values in the corresponding variables
                classA = decimal.Parse(classATextBox.Text);
                classB = decimal.Parse(classBTextBox.Text);
                classC = decimal.Parse(classCTextBox.Text);

                // Calculating revenue for each seating section
                classA *= CLASS_A_PRICE;
                classB *= CLASS_B_PRICE;
                classC *= CLASS_C_PRICE;

                // Caclulating total revenue
                total = classA + classB + classC;

                // Displaying calculated values in the label boxes in currency format
                classALabel.Text = classA.ToString("c");
                classBLabel.Text = classB.ToString("c");
                classCLabel.Text = classC.ToString("c");
                totalLabel.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                // Displaying error message if exception occured
                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Clearing contents of text labels
            classALabel.Text = "";
            classBLabel.Text = "";
            classCLabel.Text = "";
            totalLabel.Text = "";

            // Clearing TextBox controls
            classATextBox.Text = "";
            classBTextBox.Text = "";
            classCTextBox.Text = "";

            // Setting focus to Class A field
            classATextBox.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Closing form and exiting
            this.Close();
        }
    }
}

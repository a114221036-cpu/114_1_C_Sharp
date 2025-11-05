using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double km;
            double liters;
            double fuelEconomy;

            if (double.TryParse(milesTextBox.Text, out km))
            {
                if (double.TryParse(gallonsTextBox.Text, out liters))
                {
                    // Calculate fuel economy in L/100km.
                    fuelEconomy = (liters / km) * 100;
                    // Display the fuel economy rounded to two decimal places.
                    mpgLabel.Text = fuelEconomy.ToString("n2") + " L/100km";
                }
                else
                {
                    // Display an error message for invalid liters input.
                    MessageBox.Show("Please enter a valid number for liters.");
                    gallonsTextBox.Focus();
                }
            }
            else
            {
                // Display an error message for invalid kilometers input.
                MessageBox.Show("Please enter a valid number for kilometers.");
                milesTextBox.Focus();   
            }


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

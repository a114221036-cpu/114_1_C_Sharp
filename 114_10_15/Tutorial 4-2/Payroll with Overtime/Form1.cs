using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal OVERTIME_RATE = 1.5m;
            const decimal REGULAR_HOURS = 40m;

            decimal hoursWorked;    
            decimal hourlyPayRate;
            decimal grossPay;   
            
            try
                {
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);
                if (hoursWorked <= REGULAR_HOURS)
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                {
                    grossPay = (REGULAR_HOURS * hourlyPayRate) +
                               ((hoursWorked - REGULAR_HOURS) *
                                hourlyPayRate * OVERTIME_RATE);
                }
                grossPayLabel.TextAlign =ContentAlignment.MiddleRight; 
                grossPayLabel.Text = grossPay.ToString("c");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter numeric values for " +
                                "hours worked and hourly pay rate.",
                                "Input Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show("The values you entered are too large or too small.",
                                "Input Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and gross pay label.
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // Reset the focus.
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void grossPayLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

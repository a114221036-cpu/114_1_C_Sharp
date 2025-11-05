using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sentbutton_Click(object sender, EventArgs e)
        {
            String message = "點餐內容:\n";
            String drinlk = "";
            String sandwitch = "";   

            if (coffeeRadioButton.Checked)
            {
                drinlk = "咖啡 ";  
            }
            else if (milkRadioButton.Checked)
            {
                drinlk = "奶茶 ";
            }
            else if (blackTeaRadioButton.Checked)
            {
                drinlk = "紅茶 ";
            }
            else if (juiceRadioButton.Checked)
            {
                drinlk = "果汁 ";
            }

            // 三明治部分 
            if (jellySanRadioButton.Checked)
            {
                sandwitch = "果醬三明治 ";
            }
            else if (hamSanRadioButton.Checked)
            {
                sandwitch = "火腿三明治 ";
            }
            else if (tunaSanRadioButton.Checked)
            {
                sandwitch = " 鮪魚三明治 ";
            }
            else
            {
                sandwitch = "";
            }
           message = drinlk + sandwitch;    
           MessageBox.Show(message, "您的點餐內容");    

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();       
        }
    }
}

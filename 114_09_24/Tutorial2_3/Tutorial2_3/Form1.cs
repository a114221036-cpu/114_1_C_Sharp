using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial2_3
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void italianButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text="Buongiorno"；
        }

        private void spanishButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text= "Buenos Dias"；
        }

        private void germanButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text= "Guten Morgen"；
        }
    }
}

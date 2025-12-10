using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
         if (cardListBox.SelectedIndex != -1)
         {
             showSelectedCard(cardListBox.SelectedItem.ToString());
            }
         else
         {
             MessageBox.Show("請先選擇一張牌。");
            }
        }

        private void showSelectedCard(string cardName)
        {
           switch(cardName) 
            {
                case "黑桃 A":
                    // Add code to show Ace of Spades
                    showAceSpads(); 
                    break;
                case "紅心 10":
                    // Add code to show Ten of Hearts 
                    showTenHearts();
                    break;
                case "梅花 K":
                    // Add code to show King of Clubs
                    showKingClubs();    
                    break;
                default:
                    // Add code to handle unexpected input
                    break;
            }   
        }

        private void showAceSpads()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }   

        private void showTenHearts()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }


        private void showKingClubs()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }   
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void cardListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aceSpadesPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

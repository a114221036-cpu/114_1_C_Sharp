using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Friend_File
{
    public partial class Form1 : Form
        {

        private int count = 1; //成員變數，保持計數器的值
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            //int count = 1; //區域變數，每次按鈕點擊時都會重設為 1
            StreamWriter outputFile;
            try 
            {
                outputFile = File.AppendText("Friends.txt");    
                outputFile.WriteLine(nameTextBox.Text); 
                outputFile.Close(); 
            }
            catch (Exception ex)
            {
                // 如果發生錯誤，顯示錯誤訊息。
                MessageBox.Show("寫入檔案時發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
            nameTextBox.Text = "";  
            nameTextBox.Focus();    
            count++;    
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}

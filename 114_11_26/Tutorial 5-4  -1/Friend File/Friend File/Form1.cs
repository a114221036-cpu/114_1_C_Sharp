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
            saveFileDialog1.InitialDirectory = @"C:\\Users\m303\Desktop";    
            saveFileDialog1.Title = "儲存朋友清單";   

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.AppendText("Friends.txt");
                outputFile.WriteLine(nameTextBox.Text);
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("檔案未儲存");   
            }

            count++;    
        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}

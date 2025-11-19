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

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        { 
            StreamReader inputFile;
            string countryName; 

            try
            {
                inputFile = File.OpenText(@"C:\Users\m303\Desktop\114_1_C_Sharp\114_11_19\\Countries_Chinese.txt"); //開啟包含國家名稱的檔案   
                countriesListBox.Items.Clear(); //清除清單框中的所有項目

                // 讀取檔案內容直到檔案結尾 
                while (!inputFile.EndOfStream)
                {
                    string country = inputFile.ReadLine(); //讀取國家名稱
                    countriesListBox.Items.Add(country); //將國家名稱加入清單框   
                }
                inputFile.Close(); //關閉檔案   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }   
        
            // 這裡是取得國家按鈕的點擊事件處理程式。
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}

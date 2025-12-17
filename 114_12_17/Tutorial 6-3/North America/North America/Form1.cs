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

namespace North_America
{
    public partial class Form1 : Form
    {
        // 表單建構函式：初始化表單的各項設定和控制項
        public Form1()
        {
            InitializeComponent();
        }

        // GetFileName 方法：從使用者取得檔案名稱，並將其指派給作為
        // 引數傳遞的變數。此方法用於開啟檔案對話框讓使用者選擇檔案

        // GetCountries 方法：接受檔案名稱作為引數，打開指定的檔案
        // 並在 countriesListBox 控制項中顯示其內容。此方法負責讀取
        // 檔案中的北美國家清單並將其展示在使用者介面上
        

        // 獲取國家按鈕點擊事件處理程序
        // 當使用者點擊「獲取國家」按鈕時執行此方法
        // 此方法負責啟動檔案選擇流程並讀取北美國家資料
        private void getCountriesButton_Click(object sender, EventArgs e)
        {
           string fileName; // 取得檔案名稱
           GetFilrName(out fileName);
           GetCountries(fileName);   
        }


        private void GetFilrName(out string fileName)
        {
            //顯示開啟檔案對話方塊
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //使用者選擇檔案，將檔案名稱指派給引數
                fileName = openFile.FileName;
            }
            else
            {
                //如果使用者取消，將引數設為空字串
                fileName = string.Empty;
            }
        }
        private void GetCountries(string fileName)
        {
            string country;
            //顯示開啟檔案對話方塊
            if (fileName != string.Empty) 
            {
                StreamReader inputFile = File.OpenText(fileName);
                while (!inputFile.EndOfStream)
                {
                    country = inputFile.ReadLine();
                    countriesListBox.Items.Add(country);
                }
            }


            else
            {
                //如果使用者取消，將引數設為空字串
                fileName = string.Empty;
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            //關閉檔案
            this.Close();
        }

        private void countriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

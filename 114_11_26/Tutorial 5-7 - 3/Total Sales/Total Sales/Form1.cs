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
using System.Globalization;

namespace Total_Sales
{
    public partial class openFile : Form
    {
        public openFile()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile; // 宣告檔案讀取物件
            decimal totalSales = 0m; // 儲存總銷售額
            decimal currentSales = 0.0m; // 儲存目前讀取的銷售額   
            string line; // 儲存讀取的行  

            if (openFileDialog1.ShowDialog() == DialogResult.OK) // 顯示開啟檔案對話方塊  
            {


                inputFile = File.OpenText(openFileDialog1.FileName); // 開啟檔案 
                salesListBox.Items.Clear(); // 清除清單框內容


                while (!inputFile.EndOfStream) // 讀取直到檔案結尾  
                {
                    line = inputFile.ReadLine();
                    if (string.IsNullOrWhiteSpace(line))
                        continue; // 忽略空行

                    // 將行以空白分割，預期格式：MonthName value
                    var parts = line.Trim().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length < 2)
                    {
                        // 若格式不符，顯示原始行並跳過
                        this.salesListBox.Items.Add(line);
                        continue;
                    }

                    string month = parts[0];
                    // 將剩下的部份視為數值（以防月份後有多個空格或額外欄位）
                    string valuePart = parts[1];

                    // 嘗試解析數值，先以目前文化嘗試，失敗則嘗試 InvariantCulture
                    bool parsed = decimal.TryParse(valuePart, NumberStyles.Number, CultureInfo.CurrentCulture, out currentSales)
                                   || decimal.TryParse(valuePart, NumberStyles.Number, CultureInfo.InvariantCulture, out currentSales);

                    if (!parsed)
                    {
                        // 若解析失敗，將該行加入 listBox 並顯示警告，然後繼續下一行
                        this.salesListBox.Items.Add(line);
                        MessageBox.Show("無法解析數值: " + valuePart + " (來源行: " + line + ")");
                        continue;
                    }

                    // 將月份與格式化金額加入 listBox，並加總
                    this.salesListBox.Items.Add(string.Format("{0}：{1}", month, currentSales.ToString("C")));
                    totalSales += currentSales;
                }

                inputFile.Close(); // 關閉檔案
                totalLabel.Text = totalSales.ToString("C"); // 顯示總銷售額
            }

        }
    

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // 關閉表單
        }
    }
}

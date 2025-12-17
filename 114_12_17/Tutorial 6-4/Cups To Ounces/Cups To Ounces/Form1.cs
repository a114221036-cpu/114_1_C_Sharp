using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 表單構造函數 - 初始化表單組件
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// CupsToOunces 方法：將杯子轉換為流體盎司
        /// 接受杯子數量作為參數
        /// 返回等效的流體盎司數量
        /// 轉換公式：1杯 = 8流體盎司
        /// </summary>
        /// <param name="cups">杯子的數量</param>
        /// <returns>對應的流體盎司數量</returns>
        private double CupsToOunces(double cups)
        {
            return cups * 8;
        }

        /// <summary>
        /// 「轉換」按鈕的點擊事件處理程序
        /// 獲取使用者輸入的杯子數量，計算對應的流體盎司，並顯示結果
        /// </summary>
        private void convertButton_Click(object sender, EventArgs e)
        {
            double cups; // 用於存儲使用者輸入的杯子數量
            double ounces;  // 用於存儲計算出的流體盎司數量   

            if (double.TryParse(cupsTextBox.Text, out cups))
            {
                // 如果輸入有效，進行轉換
                ounces = CupsToOunces(cups);
                // 顯示結果，格式化為兩位小數
                ouncesLabel.Text = ounces.ToString("F2") + " 盎司"; 
            }
            else
            {
                // 如果輸入無效，顯示錯誤訊息
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤");

            }
        }
        private double OuncesToCups(double cups)
        {
            return cups * 8.0;
        }
        /// <summary>
        /// 「結束」按鈕的點擊事件處理程序
        /// 關閉表單並結束應用程式
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 計算平均按鈕事件：計算三個測驗分數的平均值，並顯示於 averageLabel
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //宣告三個變數來儲存三個測驗分數
            double test1, test2, test3, average;

            try
            {

            //宣告將使用者輸入的文字轉換為數字
            test1 = Convert.ToDouble(test1TextBox.Text);    
            test2 = Convert.ToDouble(test2TextBox.Text);    
            test3 = Convert.ToDouble(test3TextBox.Text);

            //計算三個測驗分數的平均值  
            average = (test1 + test2 + test3) / 3;

            //將計算出的平均分數顯示在 averageLabel 上
            averageLabel.Text = average.ToString("n2");
            }
            catch (Exception ex)
            {

            //如果轉換失敗，顯示錯誤訊息
            MessageBox.Show(ex.Message,"例外發生");
            }

        }


        // 清除按鈕事件：清空所有分數輸入框及平均分數顯示
        private void clearButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
            // 將游標移至第一個輸入框
            test1TextBox.Focus();
        }

        // 離開按鈕事件：關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 測驗一分數輸入框文字改變事件（目前未使用，可用於即時驗證或提示）
        private void test1TextBox_TextChanged(object sender, EventArgs e)
        {
            // 預留：可在此加入即時驗證或提示邏輯
        }

        // 平均分數標籤點擊事件（目前未使用）
        private void averageLabel_Click(object sender, EventArgs e)
        {
            // 預留：可在此加入額外功能
        }
    }
}

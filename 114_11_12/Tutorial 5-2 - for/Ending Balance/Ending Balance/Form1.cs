using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    // Form1 為主要的 Windows 表單類別，負責處理 UI 事件與顯示
    public partial class Form1 : Form
    {
        // 建構子：初始化表單與元件
        public Form1()
        {
            // InitializeComponent 由 Designer 自動產生，會建立並配置所有視覺元件
            InitializeComponent();
        }

        // 計算按鈕的 Click 事件處理子
        // TODO: 在此方法中實作計算邏輯（例如：依起始餘額與月份數計算每月利息或結餘）
        // 目前保留為空，讓 UI 綁定存在但不會執行任何動作
        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal INTEREST_RATE = 0.005m; // 每月利率 0.5%

            decimal startingBalance;  // 起始餘額   
            int months;               // 月份數量
            


            if (decimal.TryParse(startingBalTextBox.Text, out startingBalance))
            {
              if (int.TryParse(monthsTextBox.Text, out months) && months >0 )
                {
                 for (int count = 1; count <= months; count++)
                  {
                        // 每月結餘計算   
                        startingBalance *= (1 + INTEREST_RATE);

                        // 計算每月利息
                        decimal interest = startingBalance * INTEREST_RATE;
                      // 更新起始餘額
                      startingBalance += interest;
                      // 將每月明細加入 ListBox
                      detailListBox.Items.Add("第" + count + "個月結餘" + startingBalance.ToString("c"));
                   
                    }
                    // 顯示最終結餘
                    endingBalanceLabel.Text = startingBalance.ToString("c");  
                }
                else
                {
                    // 顯示錯誤訊息，提示使用者輸入有效的月份數量
                    MessageBox.Show("請輸入有效的月份數量", "輸入錯誤");
                }
            }
            else
            {
                // 顯示錯誤訊息，提示使用者輸入有效的數值
                MessageBox.Show("請輸入有效的起始餘額", "輸入錯誤");
            }

        }

        // 清除按鈕的 Click 事件處理子
        // 此方法會清空所有輸入欄位、輸出標籤，並清空明細列表，最後將焦點設定回起始餘額輸入框
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除 TextBox 的內容，以及顯示結餘的 Label 與明細 ListBox
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // 重設焦點到起始餘額輸入框，方便使用者繼續輸入
            startingBalTextBox.Focus();
        }

        // 退出按鈕的 Click 事件處理子
        // 關閉目前表單（結束視窗）
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，若為主要視窗則會結束應用程式
            this.Close();
        }
    }
}

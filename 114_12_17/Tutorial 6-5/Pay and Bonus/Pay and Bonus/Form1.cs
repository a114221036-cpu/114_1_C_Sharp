using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        // 提撥率常數字段 - 退休提撥比例為 5%
        private const decimal CONTRIB_RATE = 0.05m;

        /// <summary>
        /// Form1 建構子 - 初始化表單元件
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        // InputIsValid 方法用來轉換使用者輸入，並將結果儲存在以參考方式傳遞的參數中。
        // 如果轉換成功，此方法會傳回 true；否則傳回 false。
        

        /// <summary>
        /// 計算退休提撥金額的按鈕點擊事件處理程序
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal grossPay =0.0M;   
            decimal bonus =0.0m;
            decimal contribution = 0.0m;

            if (InputIsValid(out grossPay, out bonus))
            {
                contribution = CONTRIB_RATE * (grossPay + bonus);
                contributionLabel.Text = contribution.ToString("C");
            }
            else
            {
                // 顯示錯誤訊息，提示使用者輸入無效
                MessageBox.Show("請輸入有效的數值。", "輸入錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
        private bool InputIsValid(out decimal grossPay, out decimal bonus)
        {   
            bool inputIsValid = false;
            if (decimal.TryParse(grossPayTextBox.Text, out grossPay) &&
                decimal.TryParse(bonusTextBox.Text, out bonus))
            {
                inputIsValid = true;
            }
            else
            {
                grossPay = 0;
                bonus = 0;
            }   
            bool isGrossPayValid = decimal.TryParse(grossPayTextBox.Text, out grossPay);
            bool isBonusValid = decimal.TryParse(bonusTextBox.Text, out bonus);
            return isGrossPayValid && isBonusValid;
        }   


        /// <summary>
        /// 離開應用程式的按鈕點擊事件處理程序
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單視窗
            this.Close();
        }
    }
}

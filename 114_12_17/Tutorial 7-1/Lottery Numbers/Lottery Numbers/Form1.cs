using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    /// <summary>
    /// Form1 - 抽籤程式主視窗
    /// 此程式用於隨機產生五個抽籤號碼
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Form1 建構子
        /// 初始化視窗元件
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 產生號碼按鈕點擊事件處理程式
        /// 當使用者點擊「產生號碼」按鈕時，隨機產生五個號碼
        /// </summary>
        private void generateButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 5; // 抽籤號碼數量   
            int[] lotteryNumbers = new int[SIZE]; // 用於存放抽籤號碼的陣列    
            
            Label[] labels = new Label[SIZE] { firstLabel, secondLabel, thirdLabel, fourthLabel, fifthLabel };  
            Random rand = new Random(); // 建立隨機數產生器 

            for (int i = 0; i < SIZE; i++)
            {
               lotteryNumbers[i] = rand.Next(1, 50); // 產生 1 到 49 之間的隨機號碼
            }   
            //firstLabel.Text = lotteryNumbers[0].ToString(); // 顯示第一個號碼  
            //secondLabel.Text = lotteryNumbers[1].ToString(); // 顯示第二個號碼 
            //thirdLabel.Text = lotteryNumbers[2].ToString(); // 顯示第三個號碼  
            //fourthLabel.Text = lotteryNumbers[3].ToString(); // 顯示第四個號碼 
            //fifthLabel.Text = lotteryNumbers[4].ToString(); // 顯示第五個號碼  
        }


        /// <summary>
        /// 結束按鈕點擊事件處理程式
        /// 當使用者點擊「結束」按鈕時，關閉程式視窗
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉應用程式視窗
            this.Close();
        }
    }
}

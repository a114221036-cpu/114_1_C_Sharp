using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
    public partial class Form1 : Form
    {
        // 預設開獎號碼（可修改為從檔案或 UI 輸入）
        private readonly int[] winningNumbers = new int[] { 3, 12, 25, 33, 41 };

        public Form1()
        {
            InitializeComponent();
        }

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
            for (int i = 0; i < SIZE; i++)
            {
                labels[i].Text = lotteryNumbers[i].ToString(); // 顯示抽籤號碼
            }

            // 顯示本期開獎號碼（在 button2 上）
            button2.Text = "本期開獎號碼:\n" + string.Join("  ", lotteryNumbers);

            // 比對開獎號碼（不考慮順序），計算配對數與配對的號碼
            var matched = lotteryNumbers.Intersect(winningNumbers).OrderBy(n => n).ToArray();
            int matchCount = matched.Length;

            string resultMessage;
            if (matchCount == SIZE)
            {
                resultMessage = "恭喜！全部號碼中獎（頭獎）！";
            }
            else if (matchCount >= 3)
            {
                resultMessage = $"中獎！配對 {matchCount} 個號碼：{string.Join(", ", matched)}";
            }
            else
            {
                resultMessage = $"未中獎。配對 {matchCount} 個號碼：{(matchCount > 0 ? string.Join(", ", matched) : "無")}";
            }

            // 將比對結果也顯示在 button2，並跳出訊息視窗提示使用者
            button2.Text += "\n結果: " + resultMessage;
            MessageBox.Show(resultMessage, "比對結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();   
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; 
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine("Lottery Numbers:");
                    writer.WriteLine(firstLabel.Text);
                    writer.WriteLine(secondLabel.Text);
                    writer.WriteLine(thirdLabel.Text);
                    writer.WriteLine(fourthLabel.Text);
                    writer.WriteLine(fifthLabel.Text);
                }
                MessageBox.Show("Lottery numbers saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
        }
    }
}

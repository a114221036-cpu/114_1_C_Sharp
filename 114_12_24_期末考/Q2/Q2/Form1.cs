using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 清除所有輸入與輸出
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            textBox1.Text = string.Empty; // 零件費用
            textBox2.Text = string.Empty; // 工時數
            label7.Text = string.Empty; // 服務與工資
            label8.Text = string.Empty; // 零件
            label9.Text = string.Empty; // 稅金
            label10.Text = string.Empty; // 總費用
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 每小時工資率 (已修正為 NT$600/小時)
            const decimal LABOR_RATE = 600.0m;

            try
            {
                // 解析零件費用與工時數，空白視為 0
                decimal partsCost = 0m;
                decimal hours = 0m;
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (!decimal.TryParse(textBox1.Text, out partsCost) || partsCost < 0)
                    {
                        MessageBox.Show("請輸入有效的零件費用 (大於等於 0)。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (!string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    if (!decimal.TryParse(textBox2.Text, out hours) || hours < 0)
                    {
                        MessageBox.Show("請輸入有效的工時數 (大於等於 0)。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 計算所有選定服務的費用（明確對應 Designer 的單價）
                decimal servicesTotal = 0m;
                if (checkBox1.Checked) servicesTotal += 780m;   // 機油更換
                if (checkBox2.Checked) servicesTotal += 540m;   // 潤滑保養
                if (checkBox4.Checked) servicesTotal += 900m;   // 水箱清洗
                if (checkBox3.Checked) servicesTotal += 2400m;  // 變速箱清洗
                if (checkBox6.Checked) servicesTotal += 450m;   // 檢驗
                if (checkBox5.Checked) servicesTotal += 3000m;  // 更換消音器
                if (checkBox7.Checked) servicesTotal += 600m;   // 輪胎換位

                // 計算工時費用
                decimal laborCost = hours * LABOR_RATE;

                // 服務與工資總額 = 所有選定服務費用 + 工時費用
                decimal serviceAndLaborTotal = servicesTotal + laborCost;

                // 對零件費用收取 6% 稅金（只對零件收稅）
                decimal partsTax = decimal.Round(partsCost * 0.06m, 2, MidpointRounding.AwayFromZero);

                // 總費用 = 服務與工資總額 + 零件費用 + 稅金
                decimal totalCost = serviceAndLaborTotal + partsCost + partsTax;

                // 顯示結果（以 NT$ 與小數點 2 位顯示）
                label7.Text = "NT$ " + serviceAndLaborTotal.ToString("N2");
                label8.Text = "NT$ " + partsCost.ToString("N2");
                label9.Text = "NT$ " + partsTax.ToString("N2");
                label10.Text = "NT$ " + totalCost.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("計算時發生錯誤: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace How_much_insurance
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        private object insuranceAmountLabel;

        // 刪除 private object insuranceAmountLabel;
        // 不需要重新宣告，直接使用設計器產生的 Label 控制項

        public Form1()
        {
            InitializeComponent();
        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            buildingpriceLabel.Text = "";
            outputDescriptionLabel.Text = "";

            
        }

        private void insuranceaountLabel_Click(object sender, EventArgs e)
        {

        }

        // 請在 calculateButton_Click 方法結尾補上右大括號
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double buildingPrice, insuranceAmount;

        }

        private void calcuateButton_Click(object sender, EventArgs e)

        {
            try
            {
                // 假設 buildingpriceLabel 是用來輸入建築物價格的 TextBox
                double buildingPrice = Convert.ToDouble(buildingpriceLabel.Text);

                // 計算保險金額為建築物價格的 80%
                double insuranceAmount = buildingPrice * 0.8;

                // 顯示計算結果到 instranceamountLabel（假設它是 Label 控制項）
                instranceamountLabel.Text = insuranceAmount.ToString("n2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外發生");
            }
        }

        

   
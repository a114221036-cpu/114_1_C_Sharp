using System;
using System.Drawing;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        private Random rand;
        private int playerWins;
        private int computerWins;

        public Form1()
        {
            InitializeComponent();

            // 初始 random 與計數
            rand = new Random();
            playerWins = 0;
            computerWins = 0;

            // PictureBox 顯示設定（若 Designer 未設定）
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // 電腦圖
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom; // 玩家圖

            // 可在啟動時顯示預設圖（Designer 可能已設定 InitialImage/ErrorImage）
            try
            {
                pictureBox1.Image = Q1.Properties.Resources.paper_computer;
                pictureBox2.Image = Q1.Properties.Resources.paper_player;
            }
            catch
            {
                // 若 resource 名稱不同或不存在則忽略（不阻斷程式）
            }

            // 顯示初始狀態文字
            resultLabel.Text = string.Empty;
        }

        // 石頭按鈕 (Designer 綁定到 button1_Click)
        private void button1_Click(object sender, EventArgs e)
        {
            PlayRound("Stone");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        // 結束遊戲會顯示統計再結束
        private void exitButton_Click(object sender, EventArgs e)
        {
            string msg = $"遊戲統計：\n玩家勝場：{playerWins}\n電腦勝場：{computerWins}\n\n確定要結束遊戲嗎？";
            var dr = MessageBox.Show(msg, "遊戲統計", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                exitButton.Enabled = false;
                Application.Exit();
            }
        }

        // 剪刀按鈕
        private void scissorButton_Click(object sender, EventArgs e)
        {
            PlayRound("Scissors");
        }

        private void computerLabel_Click(object sender, EventArgs e)
        {
        }

        // 布按鈕
        private void paperButton_Click(object sender, EventArgs e)
        {
            PlayRound("Paper");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // 無動作或可擴充為點擊放大圖示
        }

        // 將一局遊戲流程集中處理
        private void PlayRound(string playerChoice)
        {
            // 0: Stone, 1: Paper, 2: Scissors
            int cpu = rand.Next(0, 3);
            string computerChoice = cpu == 0 ? "Stone" : cpu == 1 ? "Paper" : "Scissors";

            // 顯示圖片（使用資源名稱，Designer 內已引用 paper_computer）
            try
            {
                // 電腦圖片（resource 名稱範例：stone_computer / paper_computer / scissor_computer）
                if (computerChoice == "Stone") pictureBox1.Image = Q1.Properties.Resources.stone_computer;
                else if (computerChoice == "Paper") pictureBox1.Image = Q1.Properties.Resources.paper_computer;
                else pictureBox1.Image = Q1.Properties.Resources.scissor_computer;
            }
            catch
            {
                // 若 resource 不存在則不阻斷程式
            }

            try
            {
                // 玩家圖片（resource 名稱範例：stone_player / paper_player / scissor_player）
                if (playerChoice == "Stone") pictureBox2.Image = Q1.Properties.Resources.stone_player;
                else if (playerChoice == "Paper") pictureBox2.Image = Q1.Properties.Resources.paper_player;
                else pictureBox2.Image = Q1.Properties.Resources.scissor_player;
            }
            catch
            {
                // 忽略資源載入錯誤
            }

            // 判定勝負
            string resultText;
            if (playerChoice == computerChoice)
            {
                resultText = "平手";
            }
            else if (
                (playerChoice == "Stone" && computerChoice == "Scissors") ||
                (playerChoice == "Paper" && computerChoice == "Stone") ||
                (playerChoice == "Scissors" && computerChoice == "Paper"))
            {
                playerWins++;
                resultText = "玩家贏";
            }
            else
            {
                computerWins++;
                resultText = "電腦贏";
            }

            // 更新結果顯示（置中）
            resultLabel.Text = resultText;
            resultLabel.Font = new Font(resultLabel.Font.FontFamily, 20, FontStyle.Bold);
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}

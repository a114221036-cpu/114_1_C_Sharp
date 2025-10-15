namespace Test_Score_Average
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除正在使用的資源。
        /// </summary>
        /// <param name="disposing">如果應釋放受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 設計工具支援所需的方法 - 請勿以程式碼編輯器修改此方法內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.testScoreGroupBox = new System.Windows.Forms.GroupBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.test3promptLabel = new System.Windows.Forms.Label();
            this.test2promptLabel = new System.Windows.Forms.Label();
            this.test1promptLabel = new System.Windows.Forms.Label();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.testScoreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // testScoreGroupBox
            // 
            this.testScoreGroupBox.Controls.Add(this.outputDescriptionLabel);
            this.testScoreGroupBox.Controls.Add(this.averageLabel);
            this.testScoreGroupBox.Controls.Add(this.test3promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test2promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test1promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test3TextBox);
            this.testScoreGroupBox.Controls.Add(this.test2TextBox);
            this.testScoreGroupBox.Controls.Add(this.test1TextBox);
            this.testScoreGroupBox.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.testScoreGroupBox.Location = new System.Drawing.Point(18, 17);
            this.testScoreGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.testScoreGroupBox.Name = "testScoreGroupBox";
            this.testScoreGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.testScoreGroupBox.Size = new System.Drawing.Size(728, 469);
            this.testScoreGroupBox.TabIndex = 0;
            this.testScoreGroupBox.TabStop = false;
            this.testScoreGroupBox.Text = "請輸入三個測驗分數";
            this.testScoreGroupBox.Enter += new System.EventHandler(this.testScoreGroupBox_Enter);
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(57, 367);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(200, 55);
            this.outputDescriptionLabel.TabIndex = 7;
            this.outputDescriptionLabel.Text = "平均分數";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.averageLabel.Location = new System.Drawing.Point(318, 362);
            this.averageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(278, 65);
            this.averageLabel.TabIndex = 6;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.averageLabel.Click += new System.EventHandler(this.averageLabel_Click);
            // 
            // test3promptLabel
            // 
            this.test3promptLabel.AutoSize = true;
            this.test3promptLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.test3promptLabel.Location = new System.Drawing.Point(57, 263);
            this.test3promptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.test3promptLabel.Name = "test3promptLabel";
            this.test3promptLabel.Size = new System.Drawing.Size(244, 55);
            this.test3promptLabel.TabIndex = 5;
            this.test3promptLabel.Text = "第三次分數";
            // 
            // test2promptLabel
            // 
            this.test2promptLabel.AutoSize = true;
            this.test2promptLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.test2promptLabel.Location = new System.Drawing.Point(57, 175);
            this.test2promptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.test2promptLabel.Name = "test2promptLabel";
            this.test2promptLabel.Size = new System.Drawing.Size(244, 55);
            this.test2promptLabel.TabIndex = 4;
            this.test2promptLabel.Text = "第二次分數";
            // 
            // test1promptLabel
            // 
            this.test1promptLabel.AutoSize = true;
            this.test1promptLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.test1promptLabel.Location = new System.Drawing.Point(66, 91);
            this.test1promptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.test1promptLabel.Name = "test1promptLabel";
            this.test1promptLabel.Size = new System.Drawing.Size(244, 55);
            this.test1promptLabel.TabIndex = 3;
            this.test1promptLabel.Text = "第一次分數";
            // 
            // test3TextBox
            // 
            this.test3TextBox.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.test3TextBox.Location = new System.Drawing.Point(318, 263);
            this.test3TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(278, 66);
            this.test3TextBox.TabIndex = 2;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.test2TextBox.Location = new System.Drawing.Point(318, 172);
            this.test2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(278, 66);
            this.test2TextBox.TabIndex = 1;
            this.test2TextBox.TextChanged += new System.EventHandler(this.test2TextBox_TextChanged);
            // 
            // test1TextBox
            // 
            this.test1TextBox.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.test1TextBox.Location = new System.Drawing.Point(318, 88);
            this.test1TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(278, 66);
            this.test1TextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.calculateButton.Location = new System.Drawing.Point(38, 518);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(237, 70);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "計算平均";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.clearButton.Location = new System.Drawing.Point(303, 518);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(203, 70);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.exitButton.Location = new System.Drawing.Point(543, 518);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(203, 70);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 818);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.testScoreGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "分數平均計算";
            this.testScoreGroupBox.ResumeLayout(false);
            this.testScoreGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // 宣告所有表單元件
        private System.Windows.Forms.GroupBox testScoreGroupBox; // 分數輸入區域
        private System.Windows.Forms.Label outputDescriptionLabel; // 平均分數說明
        private System.Windows.Forms.Label averageLabel; // 顯示平均分數
        private System.Windows.Forms.Label test3promptLabel; // 第三次分數提示
        private System.Windows.Forms.Label test2promptLabel; // 第二次分數提示
        private System.Windows.Forms.Label test1promptLabel; // 第一次分數提示
        private System.Windows.Forms.TextBox test3TextBox; // 第三次分數輸入
        private System.Windows.Forms.TextBox test2TextBox; // 第二次分數輸入
        private System.Windows.Forms.TextBox test1TextBox; // 第一次分數輸入
        private System.Windows.Forms.Button calculateButton; // 計算平均按鈕
        private System.Windows.Forms.Button clearButton; // 清除按鈕
        private System.Windows.Forms.Button exitButton; // 離開按鈕
    }
}


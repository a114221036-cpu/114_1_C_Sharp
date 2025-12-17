namespace Cups_To_Ounces
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bannerLabel = new System.Windows.Forms.Label();
            this.cupsPromptLabel = new System.Windows.Forms.Label();
            this.cupsTextBox = new System.Windows.Forms.TextBox();
            this.ouncesLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bannerLabel - 標題標籤
            // 
            this.bannerLabel.AutoSize = true;
            this.bannerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bannerLabel.Location = new System.Drawing.Point(20, 15);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(350, 29);
            this.bannerLabel.TabIndex = 0;
            this.bannerLabel.Text = "杯子轉流體盎司轉換器";
            // 
            // cupsPromptLabel - 杯子輸入提示標籤
            // 
            this.cupsPromptLabel.AutoSize = true;
            this.cupsPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cupsPromptLabel.Location = new System.Drawing.Point(30, 65);
            this.cupsPromptLabel.Name = "cupsPromptLabel";
            this.cupsPromptLabel.Size = new System.Drawing.Size(90, 29);
            this.cupsPromptLabel.TabIndex = 1;
            this.cupsPromptLabel.Text = "杯子：";
            // 
            // cupsTextBox - 杯子輸入文字框
            // 
            this.cupsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cupsTextBox.Location = new System.Drawing.Point(130, 60);
            this.cupsTextBox.Name = "cupsTextBox";
            this.cupsTextBox.Size = new System.Drawing.Size(140, 41);
            this.cupsTextBox.TabIndex = 2;
            // 
            // ouncesLabel - 盎司輸出顯示標籤
            // 
            this.ouncesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ouncesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ouncesLabel.Location = new System.Drawing.Point(130, 115);
            this.ouncesLabel.Name = "ouncesLabel";
            this.ouncesLabel.Size = new System.Drawing.Size(140, 45);
            this.ouncesLabel.TabIndex = 3;
            this.ouncesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescriptionLabel - 盎司輸出說明標籤
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(30, 120);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(100, 29);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "盎司：";
            // 
            // convertButton - 轉換按鈕
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.convertButton.Location = new System.Drawing.Point(30, 180);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(120, 50);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "轉換";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton - 結束按鈕
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.exitButton.Location = new System.Drawing.Point(150, 180);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 50);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.ouncesLabel);
            this.Controls.Add(this.cupsTextBox);
            this.Controls.Add(this.cupsPromptLabel);
            this.Controls.Add(this.bannerLabel);
            this.Name = "Form1";
            this.Text = "杯子轉盎司";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bannerLabel;
        private System.Windows.Forms.Label cupsPromptLabel;
        private System.Windows.Forms.TextBox cupsTextBox;
        private System.Windows.Forms.Label ouncesLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
    }
}


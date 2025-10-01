namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dayOfWeekTextBox = new TextBox();
            monthTextBox = new TextBox();
            dayOfMonthTextBox = new TextBox();
            yearTextBox = new TextBox();
            showDateButton = new Button();
            exitButton = new Button();
            clearButton = new Button();
            dateOutputLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(82, 40);
            label1.Name = "label1";
            label1.Size = new Size(134, 61);
            label1.TabIndex = 0;
            label1.Text = "星期:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(121, 353);
            label2.Name = "label2";
            label2.Size = new Size(86, 61);
            label2.TabIndex = 1;
            label2.Text = "日:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(130, 197);
            label3.Name = "label3";
            label3.Size = new Size(86, 61);
            label3.TabIndex = 2;
            label3.Text = "月:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(130, 513);
            label4.Name = "label4";
            label4.Size = new Size(86, 61);
            label4.TabIndex = 3;
            label4.Text = "年:";
            label4.Click += label4_Click;
            // 
            // dayOfWeekTextBox
            // 
            dayOfWeekTextBox.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dayOfWeekTextBox.Location = new Point(232, 37);
            dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            dayOfWeekTextBox.Size = new Size(737, 68);
            dayOfWeekTextBox.TabIndex = 4;
            // 
            // monthTextBox
            // 
            monthTextBox.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            monthTextBox.Location = new Point(232, 197);
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(737, 68);
            monthTextBox.TabIndex = 5;
            // 
            // dayOfMonthTextBox
            // 
            dayOfMonthTextBox.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dayOfMonthTextBox.Location = new Point(232, 350);
            dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            dayOfMonthTextBox.Size = new Size(737, 68);
            dayOfMonthTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            yearTextBox.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            yearTextBox.Location = new Point(232, 513);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(737, 68);
            yearTextBox.TabIndex = 7;
            // 
            // showDateButton
            // 
            showDateButton.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            showDateButton.Location = new Point(121, 770);
            showDateButton.Name = "showDateButton";
            showDateButton.Size = new Size(208, 80);
            showDateButton.TabIndex = 8;
            showDateButton.Text = "顯示日期";
            showDateButton.UseVisualStyleBackColor = true;
            showDateButton.Click += showDateButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            exitButton.Location = new Point(725, 770);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(208, 80);
            exitButton.TabIndex = 9;
            exitButton.Text = "離開";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            clearButton.Location = new Point(418, 770);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(208, 80);
            clearButton.TabIndex = 10;
            clearButton.Text = "清除";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // dateOutputLabel
            // 
            dateOutputLabel.BorderStyle = BorderStyle.Fixed3D;
            dateOutputLabel.Location = new Point(82, 605);
            dateOutputLabel.Name = "dateOutputLabel";
            dateOutputLabel.Size = new Size(932, 119);
            dateOutputLabel.TabIndex = 11;
            dateOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 943);
            Controls.Add(dateOutputLabel);
            Controls.Add(clearButton);
            Controls.Add(exitButton);
            Controls.Add(showDateButton);
            Controls.Add(yearTextBox);
            Controls.Add(dayOfMonthTextBox);
            Controls.Add(monthTextBox);
            Controls.Add(dayOfWeekTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox dayOfWeekTextBox;
        private TextBox monthTextBox;
        private TextBox dayOfMonthTextBox;
        private TextBox yearTextBox;
        private Button showDateButton;
        private Button exitButton;
        private Button clearButton;
        private Label dateOutputLabel;
    }
}

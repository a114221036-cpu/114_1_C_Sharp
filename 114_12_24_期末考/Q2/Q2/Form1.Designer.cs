namespace Q2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OilLubeCharges = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.TaxCharges = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.FlushCharges = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.MiscCharges = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.OtherCharges = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.OilLubeCharges.SuspendLayout();
            this.FlushCharges.SuspendLayout();
            this.MiscCharges.SuspendLayout();
            this.OtherCharges.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(241, 28);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "機油更換：NT$780";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 36);
            this.textBox1.TabIndex = 1;
            // 
            // OilLubeCharges
            // 
            this.OilLubeCharges.Controls.Add(this.checkBox2);
            this.OilLubeCharges.Controls.Add(this.checkBox1);
            this.OilLubeCharges.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OilLubeCharges.Location = new System.Drawing.Point(95, 73);
            this.OilLubeCharges.Name = "OilLubeCharges";
            this.OilLubeCharges.Size = new System.Drawing.Size(291, 130);
            this.OilLubeCharges.TabIndex = 2;
            this.OilLubeCharges.TabStop = false;
            this.OilLubeCharges.Text = "機油和潤滑";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(127, 806);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(165, 71);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "計算總額";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TaxCharges
            // 
            this.TaxCharges.AutoSize = true;
            this.TaxCharges.Location = new System.Drawing.Point(34, 72);
            this.TaxCharges.Name = "TaxCharges";
            this.TaxCharges.Size = new System.Drawing.Size(110, 24);
            this.TaxCharges.TabIndex = 4;
            this.TaxCharges.Text = "零件(NT)";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(22, 81);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(241, 28);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "潤滑保養：NT$540\n";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // FlushCharges
            // 
            this.FlushCharges.Controls.Add(this.checkBox3);
            this.FlushCharges.Controls.Add(this.checkBox4);
            this.FlushCharges.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FlushCharges.Location = new System.Drawing.Point(425, 73);
            this.FlushCharges.Name = "FlushCharges";
            this.FlushCharges.Size = new System.Drawing.Size(328, 130);
            this.FlushCharges.TabIndex = 5;
            this.FlushCharges.TabStop = false;
            this.FlushCharges.Text = "清洗服務";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(22, 81);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(285, 28);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "變速箱清洗：NT$2,400";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(22, 35);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(241, 28);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "水箱清洗：NT$900";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // MiscCharges
            // 
            this.MiscCharges.Controls.Add(this.checkBox7);
            this.MiscCharges.Controls.Add(this.checkBox5);
            this.MiscCharges.Controls.Add(this.checkBox6);
            this.MiscCharges.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MiscCharges.Location = new System.Drawing.Point(95, 229);
            this.MiscCharges.Name = "MiscCharges";
            this.MiscCharges.Size = new System.Drawing.Size(310, 190);
            this.MiscCharges.TabIndex = 6;
            this.MiscCharges.TabStop = false;
            this.MiscCharges.Text = "其他服務";
            this.MiscCharges.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(22, 81);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(285, 28);
            this.checkBox5.TabIndex = 1;
            this.checkBox5.Text = "更換消音器：NT$3,000";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(22, 35);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(191, 28);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "檢驗：NT$450";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(22, 128);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(241, 28);
            this.checkBox7.TabIndex = 2;
            this.checkBox7.Text = "輪胎換位：NT$600";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // OtherCharges
            // 
            this.OtherCharges.Controls.Add(this.textBox2);
            this.OtherCharges.Controls.Add(this.label2);
            this.OtherCharges.Controls.Add(this.TaxCharges);
            this.OtherCharges.Controls.Add(this.textBox1);
            this.OtherCharges.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OtherCharges.Location = new System.Drawing.Point(425, 238);
            this.OtherCharges.Name = "OtherCharges";
            this.OtherCharges.Size = new System.Drawing.Size(356, 190);
            this.OtherCharges.TabIndex = 7;
            this.OtherCharges.TabStop = false;
            this.OtherCharges.Text = "零件和工時";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "工時數(小時)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 36);
            this.textBox2.TabIndex = 6;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(333, 806);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(174, 71);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(558, 806);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(174, 71);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox5.Location = new System.Drawing.Point(95, 448);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(621, 286);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "費用摘要";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "服務及工資";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "零件";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "稅金(零件)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "總費用";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(256, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 39);
            this.label7.TabIndex = 9;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(256, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 39);
            this.label8.TabIndex = 10;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(256, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 39);
            this.label9.TabIndex = 11;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(256, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 39);
            this.label10.TabIndex = 12;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 1128);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.OtherCharges);
            this.Controls.Add(this.MiscCharges);
            this.Controls.Add(this.FlushCharges);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.OilLubeCharges);
            this.Name = "Form1";
            this.Text = "Form1";
            this.OilLubeCharges.ResumeLayout(false);
            this.OilLubeCharges.PerformLayout();
            this.FlushCharges.ResumeLayout(false);
            this.FlushCharges.PerformLayout();
            this.MiscCharges.ResumeLayout(false);
            this.MiscCharges.PerformLayout();
            this.OtherCharges.ResumeLayout(false);
            this.OtherCharges.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox OilLubeCharges;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label TaxCharges;
        private System.Windows.Forms.GroupBox FlushCharges;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox MiscCharges;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.GroupBox OtherCharges;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}


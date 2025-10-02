namespace Tutorial_2_4
{
    partial class form1
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
            finlandPictureBox = new PictureBox();
            francePictureBox = new PictureBox();
            germanyPictureBox = new PictureBox();
            shownameLabel = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)finlandPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)francePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)germanyPictureBox).BeginInit();
            SuspendLayout();
            // 
            // finlandPictureBox
            // 
            finlandPictureBox.Image = Properties.Resources.Finland;
            finlandPictureBox.Location = new Point(64, 51);
            finlandPictureBox.Name = "finlandPictureBox";
            finlandPictureBox.Size = new Size(292, 350);
            finlandPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            finlandPictureBox.TabIndex = 0;
            finlandPictureBox.TabStop = false;
            finlandPictureBox.Click += finlandPictureBox_Click;
            // 
            // francePictureBox
            // 
            francePictureBox.Image = Properties.Resources.France;
            francePictureBox.Location = new Point(384, 51);
            francePictureBox.Name = "francePictureBox";
            francePictureBox.Size = new Size(292, 350);
            francePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            francePictureBox.TabIndex = 1;
            francePictureBox.TabStop = false;
            francePictureBox.Click += francePictureBox_Click;
            // 
            // germanyPictureBox
            // 
            germanyPictureBox.Image = Properties.Resources.Germany;
            germanyPictureBox.Location = new Point(704, 51);
            germanyPictureBox.Name = "germanyPictureBox";
            germanyPictureBox.Size = new Size(292, 350);
            germanyPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            germanyPictureBox.TabIndex = 2;
            germanyPictureBox.TabStop = false;
            germanyPictureBox.Click += germanyPictureBox_Click;
            // 
            // shownameLabel
            // 
            shownameLabel.BorderStyle = BorderStyle.Fixed3D;
            shownameLabel.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            shownameLabel.Location = new Point(64, 347);
            shownameLabel.Name = "shownameLabel";
            shownameLabel.Size = new Size(932, 101);
            shownameLabel.TabIndex = 3;
            shownameLabel.TextAlign = ContentAlignment.MiddleCenter;
            shownameLabel.Click += shownameLabel_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(281, 24);
            label2.Name = "label2";
            label2.Size = new Size(472, 54);
            label2.TabIndex = 4;
            label2.Text = "點國旗顯示名稱";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 502);
            Controls.Add(label2);
            Controls.Add(shownameLabel);
            Controls.Add(germanyPictureBox);
            Controls.Add(francePictureBox);
            Controls.Add(finlandPictureBox);
            Name = "form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)finlandPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)francePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)germanyPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox finlandPictureBox;
        private PictureBox francePictureBox;
        private PictureBox germanyPictureBox;
        private Label shownameLabel;
        private Label label2;
    }
}

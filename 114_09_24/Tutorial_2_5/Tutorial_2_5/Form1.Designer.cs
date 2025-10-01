namespace Tutorial_2_5
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
            cardfacePictureBox = new PictureBox();
            cardbackPictureBox = new PictureBox();
            showfaceButton = new Button();
            showbackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)cardfacePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardbackPictureBox).BeginInit();
            SuspendLayout();
            // 
            // cardfacePictureBox
            // 
            cardfacePictureBox.Location = new Point(99, 46);
            cardfacePictureBox.Name = "cardfacePictureBox";
            cardfacePictureBox.Size = new Size(259, 356);
            cardfacePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cardfacePictureBox.TabIndex = 0;
            cardfacePictureBox.TabStop = false;
            cardfacePictureBox.Click += cardfacePictureBox_Click;
            // 
            // cardbackPictureBox
            // 
            cardbackPictureBox.Location = new Point(573, 46);
            cardbackPictureBox.Name = "cardbackPictureBox";
            cardbackPictureBox.Size = new Size(259, 356);
            cardbackPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cardbackPictureBox.TabIndex = 1;
            cardbackPictureBox.TabStop = false;
            // 
            // showfaceButton
            // 
            showfaceButton.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            showfaceButton.Location = new Point(127, 453);
            showfaceButton.Name = "showfaceButton";
            showfaceButton.Size = new Size(219, 57);
            showfaceButton.TabIndex = 2;
            showfaceButton.Text = "顯示正面";
            showfaceButton.UseVisualStyleBackColor = true;
            showfaceButton.Click += showfaceButton_Click;
            // 
            // showbackButton
            // 
            showbackButton.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            showbackButton.Location = new Point(601, 453);
            showbackButton.Name = "showbackButton";
            showbackButton.Size = new Size(219, 57);
            showbackButton.TabIndex = 3;
            showbackButton.Text = "顯示背面";
            showbackButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 563);
            Controls.Add(showbackButton);
            Controls.Add(showfaceButton);
            Controls.Add(cardbackPictureBox);
            Controls.Add(cardfacePictureBox);
            Name = "Form1";
            Text = "顯示正面";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cardfacePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardbackPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cardfacePictureBox;
        private PictureBox cardbackPictureBox;
        private Button showfaceButton;
        private Button showbackButton;
    }
}

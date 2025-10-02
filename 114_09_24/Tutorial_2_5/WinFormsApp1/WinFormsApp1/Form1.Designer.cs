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
            cardbackPictureBox = new PictureBox();
            cardfacePictureBox = new PictureBox();
            showfaceButton = new Button();
            showbackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)cardbackPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardfacePictureBox).BeginInit();
            SuspendLayout();
            // 
            // cardbackPictureBox
            // 
            cardbackPictureBox.Image = Properties.Resources.Backface_Red;
            cardbackPictureBox.Location = new Point(587, 77);
            cardbackPictureBox.Name = "cardbackPictureBox";
            cardbackPictureBox.Size = new Size(305, 390);
            cardbackPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cardbackPictureBox.TabIndex = 0;
            cardbackPictureBox.TabStop = false;
            // 
            // cardfacePictureBox
            // 
            cardfacePictureBox.Image = Properties.Resources.Ace_Hearts;
            cardfacePictureBox.Location = new Point(138, 77);
            cardfacePictureBox.Name = "cardfacePictureBox";
            cardfacePictureBox.Size = new Size(305, 390);
            cardfacePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cardfacePictureBox.TabIndex = 1;
            cardfacePictureBox.TabStop = false;
            // 
            // showfaceButton
            // 
            showfaceButton.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            showfaceButton.Location = new Point(107, 515);
            showfaceButton.Name = "showfaceButton";
            showfaceButton.Size = new Size(362, 123);
            showfaceButton.TabIndex = 2;
            showfaceButton.Text = "顯示正面";
            showfaceButton.UseVisualStyleBackColor = true;
            showfaceButton.Click += showfaceButton_Click;
            // 
            // showbackButton
            // 
            showbackButton.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            showbackButton.Location = new Point(571, 515);
            showbackButton.Name = "showbackButton";
            showbackButton.Size = new Size(362, 123);
            showbackButton.TabIndex = 3;
            showbackButton.Text = "顯示背面";
            showbackButton.UseVisualStyleBackColor = true;
            showbackButton.Click += showbackButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 709);
            Controls.Add(showbackButton);
            Controls.Add(showfaceButton);
            Controls.Add(cardfacePictureBox);
            Controls.Add(cardbackPictureBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cardbackPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardfacePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cardbackPictureBox;
        private PictureBox cardfacePictureBox;
        private Button showfaceButton;
        private Button showbackButton;
    }
}

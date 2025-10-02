namespace Card_identifier_application
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
            eight = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)eight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // eight
            // 
            eight.Image = Properties.Resources._8_Diamonds;
            eight.Location = new Point(64, 12);
            eight.Name = "eight";
            eight.Size = new Size(189, 316);
            eight.SizeMode = PictureBoxSizeMode.Zoom;
            eight.TabIndex = 0;
            eight.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._8_Diamonds;
            pictureBox1.Location = new Point(335, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 316);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 639);
            Controls.Add(pictureBox1);
            Controls.Add(eight);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)eight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox eight;
        private PictureBox pictureBox1;
    }
}

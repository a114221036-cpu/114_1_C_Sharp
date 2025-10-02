namespace Tutorial_2_4
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void finlandPictureBox_Click(object sender, EventArgs e)
        {
            shownameLabel.Text = "芬蘭";
        }

        private void shownameLabel_Click(object sender, EventArgs e)
        {

        }

        private void francePictureBox_Click(object sender, EventArgs e)
        {
            shownameLabel.Text = "法國";
        }

        private void germanyPictureBox_Click(object sender, EventArgs e)
        {
            shownameLabel.Text = "德國";
        }
    }
}

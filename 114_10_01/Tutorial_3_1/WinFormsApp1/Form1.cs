namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            string dayOfWeek = dayOfWeekTextBox.Text;
            string month = monthTextBox.Text;
            string year = yearTextBox.Text;
            string dayOfMonth = dayOfMonthTextBox.Text;

            string output = " ���إ��� " + year + " �~ " + month + " �� " + dayOfMonth + " �� " + " ,�P�� " + dayOfWeek;

            dateOutputLabel.Text = output;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
           dayOfWeekTextBox.Text = "";  
           monthTextBox.Text = "";   
           dayOfWeekTextBox.Text = "";  
           yearTextBox.Text = "";

        }
    }
}

namespace CheckersWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player2.Enabled = false;
            Player2.Text = "[Computer]";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Player2checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Player2checkBox.Checked)
            {
                Player2.Enabled = true;
                Player2.Text = String.Empty;
            }
            else
            {
                Player2.Enabled = false;
                Player2.Text = "[Computer]";

            }
        }
    }
}
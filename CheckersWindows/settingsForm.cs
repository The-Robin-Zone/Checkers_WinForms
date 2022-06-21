namespace CheckersWindows
{
    public partial class settingsForm : Form
    {
        private readonly GameManager r_GameManager;

        public settingsForm(GameManager i_GameManager)
        {
            InitializeComponent();
            r_GameManager = i_GameManager;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            Player1.Text = "Player 1";
            Player2.Enabled = false;
            Player2.Text = "[Computer]";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int boardSize = 6;
            int numOfPlayers = 1;
            if (radio8.Checked)
            {
                boardSize = 8;
            }
            else if (radio10.Checked)
            {
                boardSize = 10;
            }

            if (Player2checkBox.Checked)
            {
                numOfPlayers = 2;
            }

            r_GameManager.InitializeGameManager(Player1.Text, Player2.Text, boardSize, numOfPlayers);

            this.Close();
        }

        private void Player2checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Player2checkBox.Checked)
            {
                Player2.Enabled = true;
                Player2.Text = string.Empty;
            }
            else
            {
                Player2.Enabled = false;
                Player2.Text = "[Computer]";
            }
        }

        private void Player1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Player2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
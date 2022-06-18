using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckersWindows
{

    public partial class Form2 : Form
    {
        private readonly GameManager r_GameManager;
        private Button[,] m_ButtonArray;
        private bool m_PawnNotSelcted = true;

        public Form2(GameManager  i_GameManager)
        {

            InitializeComponent();
            r_GameManager = i_GameManager;
            this.AllowDrop = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            ScorePlayer1.TabStop = false;
            ScorePlayer2.TabStop = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Player1.Text = r_GameManager.Player1.PlayerName;
            Player2.Text = r_GameManager.Player2.PlayerName;
            ScorePlayer1.Text = r_GameManager.Player1.Score.ToString();
            ScorePlayer2.Text = r_GameManager.Player2.Score.ToString();

            m_ButtonArray = new Button[r_GameManager.GameBoard.BoardSize, r_GameManager.GameBoard.BoardSize];
            int left = 0;
            int top = 150;
            Color[] colors = new Color[] { Color.White, Color.Black };
            for (int i = 1; i < r_GameManager.GameBoard.BoardSize - 1; i++)
            {
                left = 0;
                if (i % 2 == 0) { colors[0] = Color.White; colors[1] = Color.Black; }
                else { colors[0] = Color.Black; colors[1] = Color.White; }

                for (int j = 1; j < r_GameManager.GameBoard.BoardSize - 1; j++)
                {
                    m_ButtonArray[i, j] = new Button();
                    m_ButtonArray[i, j].Name = String.Format("{0}{1}",i, j);
                    m_ButtonArray[i, j].BackColor = colors[(j % 2 == 0) ? 1 : 0];
                    if (m_ButtonArray[i, j].BackColor == Color.Black)
                    {
                        m_ButtonArray[i, j].Enabled = false;
                    } 
                    m_ButtonArray[i, j].Location = new Point(left, top);
                    m_ButtonArray[i, j].Size = new Size(60, 60);
                    left += 60;

                    if (r_GameManager.GameBoard.Board[i, j] != null)
                    {
                        if (r_GameManager.GameBoard.Board[i, j].CoinColor.CompareTo('O') == 0)
                        {
                            m_ButtonArray[i, j].Image = Image.FromFile(@"Assets\WhitePawn.png");
                            m_ButtonArray[i, j].ImageAlign = ContentAlignment.MiddleCenter; 
                        }
                        else if(r_GameManager.GameBoard.Board[i, j].CoinColor.CompareTo('X') == 0)
                        {
                            m_ButtonArray[i, j].Image = Image.FromFile(@"Assets\BlackPawn.png");
                            m_ButtonArray[i, j].ImageAlign = ContentAlignment.MiddleCenter;
                        }
                    }
                    m_ButtonArray[i, j].MouseEnter += (sender1, e1) =>
                    {
                        Button button = sender1 as Button;
                        
                        if (button.BackColor != Color.LightBlue)
                        {
                            button.BackColor = Color.Blue;
                        }

                    };
                    m_ButtonArray[i, j].MouseLeave += (sender2, e2) =>
                    {
                        Button button = sender2 as Button;
                        if (button.BackColor != Color.LightBlue)
                        {
                            button.BackColor = Color.White;
                        }
                        
                    };
                    m_ButtonArray[i, j].Click += (sender3, e3) =>
                    {   
                        Button button = sender3 as Button;
                        if (button.Image != null && button.BackColor != Color.LightBlue && m_PawnNotSelcted)
                        {
                            button.BackColor = Color.LightBlue;
                            m_PawnNotSelcted = false;
                            r_GameManager.StartLocation = button.Name;
                        }
                        else if (button.BackColor == Color.LightBlue)
                        {
                            button.BackColor = Color.White;
                            m_PawnNotSelcted = true;
                        }
                        else if (button.Image == null && !m_PawnNotSelcted)
                        {
                            r_GameManager.EndLocation = button.Name;
                            r_GameManager.StartTurn();
                            int xPosition = r_GameManager.StartLocation[0] - '0';
                            int yPosition = r_GameManager.StartLocation[1] - '0';
                            m_ButtonArray[xPosition, yPosition].BackColor = Color.White;
                            m_PawnNotSelcted = true;

                        }
                    };
                    this.Controls.Add(m_ButtonArray[i, j]);

                    };
                top += 60;
            }

            if (r_GameManager.GameBoard.BoardSize == 8)
            {
                this.Size = new Size(380, 560);
                panel2.Location = new Point(180, 31);
            }
            else if (r_GameManager.GameBoard.BoardSize == 10)
            {
                this.Size = new Size(500,680);
                panel1.Size = new Size(240, 120);
                panel2.Size = new Size(240, 120);
                panel2.Location = new Point(240, 31);
            }
            else if (r_GameManager.GameBoard.BoardSize == 12)
            {
                this.Size = new Size(620, 800);
                panel1.Size = new Size(300, 120);
                panel2.Size = new Size(300, 120);
                panel2.Location = new Point(300, 31);
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Player1_Click(object sender, EventArgs e)
        {

        }
        public void MovePawn(int i_XStart, int i_YStart, int i_XEnd, int i_YEnd)
        {
            m_ButtonArray[i_XEnd, i_YEnd].Image = m_ButtonArray[i_XStart, i_YStart].Image;
            m_ButtonArray[i_XStart, i_YStart].Image = null;
            m_ButtonArray[i_XStart, i_YStart].BackColor = Color.White;
            m_ButtonArray[i_XEnd, i_YEnd].BackColor = Color.White;
            m_PawnNotSelcted = true;

        }

        private void ScorePlayer2_TextChanged(object sender, EventArgs e)
        {

        }

        public void CoinCaptured(int i_XStart, int i_YStart, int i_XEnd, int i_YEnd)
        {
            int xMiddle = (i_XStart + i_XEnd) / 2;
            int yMiddle = (i_YStart + i_YEnd) / 2;
            m_ButtonArray[xMiddle, yMiddle].Image = null;
            m_ButtonArray[i_XStart, i_YStart].BackColor = Color.White;
            m_ButtonArray[i_XEnd, i_YEnd].BackColor = Color.White;
            m_PawnNotSelcted = true;

        }

        public void TurnToKing(int i_X, int i_Y)
        {
            m_ButtonArray[i_X, i_Y].Image = null;
            if ( i_X == 1)
            {
                m_ButtonArray[i_X, i_Y].Image = Image.FromFile(@"Assets\BlackKing.png");
            }
            else
            {
                m_ButtonArray[i_X, i_Y].Image = Image.FromFile(@"Assets\WhiteKing.png");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 gameRules = new Form3();
            gameRules.ShowDialog();
        }

        private void ScorePlayer1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Player1.Text = r_GameManager.Player1.PlayerName;
            Player2.Text = r_GameManager.Player2.PlayerName;
            ScorePlayer1.Text = r_GameManager.Player1.Score.ToString();
            ScorePlayer2.Text = r_GameManager.Player2.Score.ToString();

            m_ButtonArray = new Button[r_GameManager.GameBoard.BoardSize, r_GameManager.GameBoard.BoardSize];
            int left = 20;
            int top = 150;
            Color[] colors = new Color[] { Color.White, Color.Black };
            for (int i = 1; i < r_GameManager.GameBoard.BoardSize - 1; i++)
            {
                left = 20;
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
                           // r_GameManager.startTurn();

                        }
                    };
                    this.Controls.Add(m_ButtonArray[i, j]);

                    };
                top += 60;
            }

            this.Size = new Size(r_GameManager.GameBoard.BoardSize * 80, r_GameManager.GameBoard.BoardSize * 80);
            //r_GameManager.startGame();

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


    }
}

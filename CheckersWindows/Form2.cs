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
        public Form2(GameManager  i_GameManager)
        {
            InitializeComponent();
            r_GameManager = i_GameManager;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Player1.Text = r_GameManager.Player1.PlayerName;
            Player2.Text = r_GameManager.Player2.PlayerName;
            ScorePlayer1.Text = r_GameManager.Player1.Score.ToString();
            ScorePlayer2.Text = r_GameManager.Player2.Score.ToString();

            PictureBox[,] boardPic = new PictureBox[r_GameManager.GameBoard.BoardSize, r_GameManager.GameBoard.BoardSize];
            int left = 20;
            int top = 150;
            Color[] colors = new Color[] { Color.White, Color.Black };
            for (int i = 0; i < r_GameManager.GameBoard.BoardSize - 2; i++)
            {
                left = 20;
                if (i % 2 == 0) { colors[0] = Color.White; colors[1] = Color.Black; }
                else { colors[0] = Color.Black; colors[1] = Color.White; }

                for (int j = 0; j < r_GameManager.GameBoard.BoardSize - 2; j++)
                {
                    boardPic[i, j] = new PictureBox();
                    boardPic[i, j].BackColor = colors[(j % 2 == 0) ? 1 : 0];
                    boardPic[i, j].Location = new Point(left, top);
                    boardPic[i, j].Size = new Size(60, 60);
                    left += 60;
                    this.Controls.Add(boardPic[i, j]);
                }
                top += 60;
            }

            for (int i = 0; i < r_GameManager.GameBoard.BoardSize - 2; i++)
            {
                for (int j = 0; j < r_GameManager.GameBoard.BoardSize - 2; j++)
                {
                    if (r_GameManager.GameBoard.Board[i, j].CoinColor ==)
                    boardPic[i, j].Image = Image.FromFile(@"Assets\BlackPawn.png");
                    boardPic[i, j].SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                }
            }

                this.Size = new Size(r_GameManager.GameBoard.BoardSize * 80, r_GameManager.GameBoard.BoardSize * 80);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Player1_Click(object sender, EventArgs e)
        {

        }
    }
}

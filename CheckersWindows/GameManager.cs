using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersWindows
{
    public class GameManager
    {
        public static Form2 m_Form = Application.OpenForms.OfType<Form2>().FirstOrDefault();
        private Player m_Player1;
        private Player m_Player2;
        private Player m_CurrPlayerTurn;
        private Player m_CurrEnemyPlayer;
        private GameBoard m_GameBoard;
        private bool m_IsRoundDraw;
        private bool m_HasRoundEnded;
        private int m_NumOfPlayers;
        private string m_StartLocation;
        private string m_EndLocation;
        private int m_XLimitedTurn;
        private int m_YLimitedTurn;
        private bool m_IsLimitedTurn;

        public GameManager()
        {
        }

        public void InitializeGameManager(string i_Player1, string i_Player2, int i_BoardSize, int i_NumOfPlayers)
        {
            m_NumOfPlayers = i_NumOfPlayers;
            int boardSize = i_BoardSize;
            this.m_Player1 = new Player(i_Player1, boardSize, 'O');
            this.m_Player2 = new Player(i_Player2, boardSize, 'X');
            this.m_GameBoard = new GameBoard(boardSize);
            this.m_GameBoard.InitializeBoard();
            this.m_IsRoundDraw = false;
            this.m_CurrPlayerTurn = Player1;
            this.m_CurrEnemyPlayer = Player2;
            this.m_IsLimitedTurn = false;
        }

        public Player Player1
        {
            get
            {
                return this.m_Player1;
            }
        }

        public Player Player2
        {
            get
            {
                return this.m_Player2;
            }
        }

        public Player CurrentPlayer
        {
            get
            {
                return this.m_CurrPlayerTurn;
            }
        }

        public GameBoard GameBoard
        {
            get
            {
                return this.m_GameBoard;
            }
        }

        public string StartLocation
        {
            get
            {
                return this.m_StartLocation;
            }

            set
            {
                this.m_StartLocation = value;
            }
        }

        public string EndLocation
        {
            set
            {
                this.m_EndLocation = value;
            }
        }

        public void StartTurn()
        {
            bool isMoveJump = true;
            int xStart = m_StartLocation[0] - '0';
            int yStart = m_StartLocation[1] - '0';
            int xEnd = m_EndLocation[0] - '0';
            int yEnd = m_EndLocation[1] - '0';

            if (!isPlayerMoveLegal(xStart, yStart, xEnd, yEnd))
            {
                m_Form.Text = string.Format("Checkers ({0}'s turn)", m_CurrEnemyPlayer.PlayerName);

                // Check if move is jump
                isMoveJump = Logic.IsJump(m_GameBoard, m_CurrPlayerTurn.Color, xStart, yStart, xEnd, yEnd);

                // Move Coin
                moveCoin(xStart, yStart, xEnd, yEnd);

                // Turn coin to king if needed
                if (Logic.ShouldTurnKing(this.m_GameBoard, xEnd, yEnd))
                {
                    turnToKing(xEnd, yEnd);
                }

                if (isMoveJump)
                {
                    makeCoinCapture(m_CurrPlayerTurn, m_CurrEnemyPlayer, xStart, yStart, xEnd, yEnd);
                }

                // Check for draw before ending pl.m_HasRoundEndedayers turn
                if (Logic.IsDraw(this.m_GameBoard, m_CurrPlayerTurn) && Logic.IsDraw(this.m_GameBoard, m_CurrEnemyPlayer))
                {
                    this.m_HasRoundEnded = true;
                    this.m_IsRoundDraw = true;
                    endRound();
                }

                if (Logic.AllMovePossible(m_GameBoard, m_Player1).Count == 0 || Logic.AllMovePossible(m_GameBoard, m_Player2).Count == 0)
                {
                    endRound();
                }

                if (!m_IsLimitedTurn)
                {
                    Player tempPlayer = m_CurrPlayerTurn;
                    m_CurrPlayerTurn = m_CurrEnemyPlayer;
                    m_CurrEnemyPlayer = tempPlayer;
                }

                if (m_NumOfPlayers == 1 && m_CurrPlayerTurn == m_Player2)
                {
                    string move = Logic.NextMoveComputer(m_GameBoard, m_Player2);
                    m_StartLocation = move.Substring(0, 2);
                    m_EndLocation = move.Substring(2);
                    StartTurn();
                }
            }      
        }

        private void makeCoinCapture(Player i_CurrPlayerTurn, Player i_CurrEnemyPlayer, int i_XStart, int i_YStart, int i_XEnd, int i_YEnd)
        {
            bool wasKingCaptured = this.m_GameBoard.Board[(i_XStart + i_XEnd) / 2, (i_YStart + i_YEnd) / 2].IsKing;
            this.m_GameBoard.Board[(i_XStart + i_XEnd) / 2, (i_YStart + i_YEnd) / 2] = null;
            m_Form.CoinCaptured(i_XStart, i_YStart, i_XEnd, i_YEnd);

            // Updates enemy player Coin count
            if (wasKingCaptured)
            {
                i_CurrEnemyPlayer.NumberKingsLeft--;
            }
            else
            {
                i_CurrEnemyPlayer.NumberPawnsLeft--;
            }

            // Check if another capture is possible
            if (Logic.IsJumpAvailable(this.m_GameBoard, i_CurrPlayerTurn.Color, i_XEnd, i_YEnd))
            {
                m_IsLimitedTurn = true;
                m_XLimitedTurn = i_XEnd;
                m_YLimitedTurn = i_YEnd;
            }

            // Check enemy's amount of coins, if none left current player wins
            if (i_CurrEnemyPlayer.NumberPawnsLeft == 0 && i_CurrEnemyPlayer.NumberKingsLeft == 0)
            {
                this.m_HasRoundEnded = true;
                endRound();
            }
        }

        private void endRound()
        {
            DialogResult dialogResult = DialogResult.None;

            // Score calculation if round didn't end with a draw
            if (!this.m_IsRoundDraw)
            {
                int player1score = m_Player1.NumberPawnsLeft + (m_Player1.NumberKingsLeft * 4);
                int player2score = m_Player2.NumberPawnsLeft + (m_Player2.NumberKingsLeft * 4);

                if (player1score > player2score)
                {
                    m_Player1.Score += player1score - player2score;
                    m_Form.ScorePlayer1.Text = m_Player1.Score.ToString();
                    dialogResult = MessageBox.Show(string.Format("{0} Won!" + Environment.NewLine + "Another Round?", m_Player1.PlayerName), "Checkers", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }

                if (player1score < player2score)
                {
                    m_Player2.Score += player2score - player1score;
                    m_Form.ScorePlayer2.Text = m_Player2.Score.ToString();
                    dialogResult = MessageBox.Show(string.Format("{0} Won!" + Environment.NewLine + "Another Round?", m_Player2.PlayerName), "Checkers", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
            }
            else
            {
                dialogResult = MessageBox.Show(string.Format("Tie!" + Environment.NewLine + "Another Round?"), "Checkers", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (dialogResult == DialogResult.Yes)
            {
                this.m_GameBoard.ClearBoard();
                this.m_GameBoard.InitializeBoard();
                InitializePlayers();
                this.m_CurrPlayerTurn = this.m_Player1;
                this.m_CurrEnemyPlayer = this.m_Player2;
                this.m_HasRoundEnded = false;
                m_Form.Hide();
                m_Form = new Form2(this);
                m_Form.ShowDialog();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private bool isPlayerMoveLegal(int i_XStart, int i_YStart, int i_XEnd, int i_YEnd)
        {
            bool o_IsMoveLogicIllegal = true;
            o_IsMoveLogicIllegal = !Logic.MoveIsValid(this.m_GameBoard, m_CurrPlayerTurn, i_XStart, i_YStart, i_XEnd, i_YEnd);
            if (m_IsLimitedTurn)
            {
                if (m_XLimitedTurn != i_XStart || m_YLimitedTurn != i_YStart)
                {
                    o_IsMoveLogicIllegal = true;
                } 
                else
                {
                    m_IsLimitedTurn = false;
                }
            }

            if (o_IsMoveLogicIllegal)
            {
                if (!Logic.NoOpponentToEat(this.m_GameBoard, m_CurrPlayerTurn.Color))
                {
                    MessageBox.Show("Illegal Move - You must Capture Opponent");
                }
                else
                {
                    MessageBox.Show("Illegal Move");
                }
            }

            return o_IsMoveLogicIllegal;
        }

        private void moveCoin(int i_XStart, int i_YStart, int i_XEnd, int i_YEnd)
        {
            this.m_GameBoard.Board[i_XEnd, i_YEnd] = this.m_GameBoard.Board[i_XStart, i_YStart];
            this.m_GameBoard.Board[i_XStart, i_YStart] = null;
            m_Form.MovePawn(i_XStart, i_YStart, i_XEnd, i_YEnd);
        }

        private void turnToKing(int i_XEnd, int i_YEnd)
        {
            this.m_GameBoard.Board[i_XEnd, i_YEnd].IsKing = true;
            if (this.m_GameBoard.Board[i_XEnd, i_YEnd].CoinColor == 'O')
            {
                this.m_GameBoard.Board[i_XEnd, i_YEnd].CoinColor = 'Q';
                m_Player1.NumberKingsLeft++;
                m_Player1.NumberPawnsLeft--;
            }

            if (this.m_GameBoard.Board[i_XEnd, i_YEnd].CoinColor == 'X')
            {
                this.m_GameBoard.Board[i_XEnd, i_YEnd].CoinColor = 'Z';
                m_Player2.NumberKingsLeft++;
                m_Player2.NumberPawnsLeft--;
            }

            m_Form.TurnToKing(i_XEnd, i_YEnd);
        }

        private void InitializePlayers()
        {
            this.m_Player1.NumberPawnsLeft = (((this.m_GameBoard.BoardSize - 2) / 2) - 1) * (this.m_GameBoard.BoardSize - 2) / 2;
            this.m_Player2.NumberPawnsLeft = (((this.m_GameBoard.BoardSize - 2) / 2) - 1) * (this.m_GameBoard.BoardSize - 2) / 2;
            this.m_Player1.NumberKingsLeft = 0;
            this.m_Player2.NumberKingsLeft = 0;
    }
    }
}

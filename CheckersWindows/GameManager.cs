using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersWindows
{
    public class GameManager
    {
        private Player m_Player1;
        private Player m_Player2;
        private GameBoard m_GameBoard;
        private bool m_HasRoundEnded;
        private bool m_IsRoundDraw;
        private int m_NumOfPlayers;
        private string m_StartLocation;
        private string m_EndLocation;
        static Form2 m_Form = Application.OpenForms.OfType<Form2>().FirstOrDefault();

        public GameManager()
        {

        }
        public void InitializeGameManager(string i_Player1, string i_Player2, int i_BoardSize,int i_NumOfPlayers)
        {
            m_NumOfPlayers = i_NumOfPlayers;
            int boardSize = i_BoardSize;
            this.m_Player1 = new Player(i_Player1, boardSize, 'O');
            this.m_Player2 = new Player(i_Player2, boardSize, 'X');
            this.m_GameBoard = new GameBoard(boardSize);
            this.m_GameBoard.InitializeBoard();
            this.m_HasRoundEnded = false;
            this.m_IsRoundDraw = false;
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

        public GameBoard GameBoard
        {
            get
            {
                return this.m_GameBoard;
            }
        }

        public string StartLocation
        {
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

        public void startGame()
        {
            while (!m_HasRoundEnded)
            {
                if (Logic.AllMovePossible(m_GameBoard, m_Player1).Count != 0)
                {
                    StartTurn(m_Player1, m_Player2);
                }

                if (Logic.AllMovePossible(m_GameBoard, m_Player2).Count != 0)
                {
                    StartTurn(m_Player2, m_Player1);
                }

                if (Logic.AllMovePossible(m_GameBoard, m_Player1).Count == 0 && Logic.AllMovePossible(m_GameBoard, m_Player2).Count == 0)
                {
                    endRound();
                }
            }

            endRound();
        }

        private void StartTurn(Player i_CurrPlayerTurn, Player i_CurrEnemyPlayer)
        {
            bool isMoveJump = true;
            int[] PlayerMove = new int[4];

            if (m_NumOfPlayers == 1 && string.Equals(i_CurrPlayerTurn.PlayerName, "Computer"))
            {
                //PlayerMove = Logic.NextMoveComputer(m_GameBoard, m_Player2);
            }
            else
            {
                PlayerMove = getPlayerMove(i_CurrPlayerTurn);
            }

            int xStart = PlayerMove[0];
            int yStart = PlayerMove[1];
            int xEnd = PlayerMove[2];
            int yEnd = PlayerMove[3];

            // Check if move is jump
            isMoveJump = Logic.IsJump(m_GameBoard, i_CurrPlayerTurn.Color, xStart, yStart, xEnd, yEnd);

            // Move Coin
            moveCoin(xStart, yStart, xEnd, yEnd);


            // Turn coin to king if needed
            if (Logic.ShouldTurnKing(this.m_GameBoard, xEnd, yEnd))
            {
                turnToKing(xEnd, yEnd);
            }

            if (isMoveJump)
            {
                makeCoinCapture(i_CurrPlayerTurn, i_CurrEnemyPlayer, xStart, yStart, xEnd, yEnd);
            }

            // Check for draw before ending players turn
            if (Logic.IsDraw(this.m_GameBoard, i_CurrPlayerTurn) && Logic.IsDraw(this.m_GameBoard, i_CurrEnemyPlayer))
            {
                this.m_HasRoundEnded = true;
                this.m_IsRoundDraw = true;
                endRound();
            }

        }

        private void makeCoinCapture(Player i_CurrPlayerTurn, Player i_CurrEnemyPlayer, int i_XStart, int i_YStart, int i_XEnd, int i_YEnd)
        {
            bool wasKingCaptured = this.m_GameBoard.Board[(i_XStart + i_XEnd) / 2, (i_YStart + i_YEnd) / 2].IsKing;
            this.m_GameBoard.Board[(i_XStart + i_XEnd) / 2, (i_YStart + i_YEnd) / 2] = null;

            // Updates enemy player Coin count
            if (wasKingCaptured)
            {
                i_CurrEnemyPlayer.NumberKingsLeft--;
            }
            else
            {
                i_CurrEnemyPlayer.NumberPawnsLeft--;
            }

            // Check enemy's amount of coins, if none left current player wins
            if (i_CurrEnemyPlayer.NumberPawnsLeft == 0 && i_CurrEnemyPlayer.NumberKingsLeft == 0)
            {
                this.m_HasRoundEnded = true;
                endRound();
            }

            // Check if another capture is possible
            if (Logic.IsJumpAvalaible(this.m_GameBoard, i_CurrPlayerTurn.Color, i_XEnd, i_YEnd))
            {
                limitedTurn(i_CurrPlayerTurn, i_CurrEnemyPlayer, i_XEnd, i_YEnd);
            }
        }

        private void limitedTurn(Player i_CurrPlayerTurn, Player i_CurrEnemyPlayer, int i_XActuallPoint, int i_YActuallPoint)
        {
            string playerLimitedMove = string.Empty;
            bool isLimitedMoveIllegal = true;
            int xStart = 0;
            int yStart = 0;
            int xEnd = 0;
            int yEnd = 0;

            while (isLimitedMoveIllegal)
            {
                if (m_NumOfPlayers == 1 && string.Equals(i_CurrPlayerTurn.PlayerName, "Computer"))
                {
                    playerLimitedMove = Logic.NextMoveComputer(m_GameBoard, m_Player2);
                }
                else
                {
                    //playerLimitedMove = getPlayerMove(i_CurrPlayerTurn);
                }

                xStart = playerLimitedMove[1] - 'a' + 1;
                yStart = playerLimitedMove[0] - 'A' + 1;
                xEnd = playerLimitedMove[4] - 'a' + 1;
                yEnd = playerLimitedMove[3] - 'A' + 1;

                if (xStart == i_XActuallPoint && yStart == i_YActuallPoint)
                {
                    isLimitedMoveIllegal = false;
                }
            }

            // Move Coin
            moveCoin(xStart, yStart, xEnd, yEnd);

            // Turn coin to king if needed
            if (Logic.ShouldTurnKing(this.m_GameBoard, xEnd, yEnd))
            {
                turnToKing(xEnd, yEnd);
            }

            // Do actual capture
            makeCoinCapture(i_CurrPlayerTurn, i_CurrEnemyPlayer, xStart, yStart, xEnd, yEnd);
        }

        private void endRound()
        {
            char userChoice = ' ';

            // Score calculation if round didn't end with a draw
            if (this.m_IsRoundDraw == false)
            {
                int player1score = m_Player1.NumberPawnsLeft + (m_Player1.NumberKingsLeft * 4);
                int player2score = m_Player2.NumberPawnsLeft + (m_Player2.NumberKingsLeft * 4);

                if (player1score > player2score)
                {
                    m_Player1.Score = player1score - player2score;
                    //Output.EndRoundPrompt(m_Player1.PlayerName);
                }

                if (player1score < player2score)
                {
                    m_Player2.Score = player2score - player1score;
                    //Output.EndRoundPrompt(m_Player2.PlayerName);
                }
            }
            else
            {
                //Output.EndRoundPrompt("Nobody");
            }

            while (userChoice != 'q' || userChoice != 'n')
            {
                //userChoice = Input.ReadChar();

                if (userChoice == 'n')
                {
                    this.m_GameBoard.ClearBoard();
                    this.m_GameBoard.InitializeBoard();
                    this.m_HasRoundEnded = false;
                    startGame();
                }

            }
        }

        public int[] getPlayerMove(Player i_CurrPlayerTurn)
        {
            string o_PlayerMove = string.Empty;
            bool isMoveLogicIllegal = true;
            int[] o_MoveArray = new int[] { (int)m_StartLocation[0], (int)m_StartLocation[1], (int)m_EndLocation[0], (int)m_EndLocation[1] };

       
            // Checks that move is  logically legal
            while (isMoveLogicIllegal)
            {

                isMoveLogicIllegal = !Logic.MoveIsValid(this.m_GameBoard, i_CurrPlayerTurn, o_MoveArray);
  
                if (isMoveLogicIllegal)
                {
                    if (!Logic.NoOpponentToEat(this.m_GameBoard, i_CurrPlayerTurn.Color))
                    {
                        //Output.MustCapturePromt();
                    }
                    else
                    {
                        //Output.InvalidInputPrompt();
                    }

                }
            }

            return o_MoveArray;
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
        }
    }
}

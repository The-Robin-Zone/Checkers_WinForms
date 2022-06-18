using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersWindows
{
    public class GameBoard
    {
        private readonly Coin[,] r_Board;
        private int m_BoardSize;

        public GameBoard(int i_boardSize)
        {
            this.m_BoardSize = i_boardSize + 2;
            this.r_Board = new Coin[this.m_BoardSize, this.m_BoardSize];
        }

        public Coin[,] Board
        {
            get
            {
                return this.r_Board;
            }
        }

        public int BoardSize
        {
            get
            {
                return this.m_BoardSize;
            }

            set
            {
                this.m_BoardSize = value;
            }
        }

        public void InitializeBoard()
        {
            int numOfCoinRows = ((this.m_BoardSize - 2) / 2) - 1;

            // Initialize 'O' Coins
            for (int i = 1; i < numOfCoinRows + 1; i++)
            {
                for (int j = 1; j < this.m_BoardSize - 1; j++)
                {
                    if (i % 2 != 0 && j % 2 == 0)
                    {
                        this.r_Board[i, j] = new Coin('O');
                    }

                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        this.r_Board[i, j] = new Coin('O');
                    }
                }
            }

            // Initialize X Coins
            for (int i = this.m_BoardSize - 2; i > numOfCoinRows + 2; i--)
            {
                for (int j = 1; j < this.m_BoardSize - 1; j++)
                {
                    if (i % 2 != 0 && j % 2 == 0)
                    {
                        this.r_Board[i, j] = new Coin('X');
                    }

                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        this.r_Board[i, j] = new Coin('X');
                    }
                }
            }
        }

        public void ClearBoard()
        {
            for (int i = 0; i < this.m_BoardSize; i++)
            {
                for (int j = 0; j < this.m_BoardSize; j++)
                {
                    this.r_Board[i, j] = null;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersWindows
{
    public class Player
    {
        private string m_PlayerName;
        private int m_Score;
        private int m_NumberPawnsLeft;
        private int m_NumberKingsLeft;
        private char m_CoinColor;

        public Player(string i_PlayerName, int i_BoardSize, char i_CoinColor)
        {
            this.m_PlayerName = i_PlayerName;
            this.m_Score = 0;
            this.m_NumberPawnsLeft = ((i_BoardSize - 2) * i_BoardSize) / 4;
            this.m_CoinColor = i_CoinColor;
        }

        public string PlayerName
        {
            get
            {
                return this.m_PlayerName;
            }
        }

        public int Score
        {
            get
            {
                return this.m_Score;
            }

            set
            {
                this.m_Score = value;
            }
        }

        public int NumberPawnsLeft
        {
            get
            {
                return this.m_NumberPawnsLeft;
            }

            set
            {
                this.m_NumberPawnsLeft = value;
            }
        }

        public int NumberKingsLeft
        {
            get
            {
                return this.m_NumberKingsLeft;
            }

            set
            {
                this.m_NumberKingsLeft = value;
            }
        }

        public char Color
        {
            get
            {
                return this.m_CoinColor;
            }
        }
    }
}


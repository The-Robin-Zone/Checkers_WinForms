using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersWindows
{
    public class Coin
    {
        private char m_CoinColor;
        private bool m_IsKing;

        public Coin(char i_coinColor)
        {
            this.m_CoinColor = i_coinColor;
            this.m_IsKing = false;
        }

        public char CoinColor
        {
            get
            {
                return this.m_CoinColor;
            }

            set
            {
                this.m_CoinColor = value;
            }
        }

        public bool IsKing
        {
            get
            {
                return this.m_IsKing;
            }

            set
            {
                this.m_IsKing = value;
            }
        }
    }
}


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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            richTextBox1.Text += "Game instructions:" + Environment.NewLine + "1. Each pawn can move forward only, one square at a time in a diagonal direction, to an unoccupied square." + Environment.NewLine +
                "2. Player 1 (White) plays first" + Environment.NewLine + "3. The object of the game is to prevent the opponent from being able to move when it is his turn to do so. \nThis is accomplished either by capturing all of the opponent's pawns, or by blocking those that remain so that none of them can be moved. \nIf neither player can accomplish this, the game is a draw." + Environment.NewLine +
                "4. Pawn capture by jumping over an opposing pawn on a diagonally adjacent square to the square immediately beyond, but may do so only if this square is unoccupied." + Environment.NewLine +
                "5. Pawn may jump forward only, and may continue jumping as long as they encounter opposing pawns with unoccupied squares immediately beyond them. \nPawn may never jump over a pawn of the same color." + Environment.NewLine +
                "6. A pawn which reaches the far side of the board, whether by means of a jump or a simple move, becomes a King," + Environment.NewLine +
                "7. Kings can move forward or backward, one square at a time in a diagonal direction to an unoccupied square." + Environment.NewLine +
                "8. Whenever a player is able to make a capture he must do so. \nWhen there is more than one way to jump, a player may choose any way he wishes, not necessarily the one which results in the capture of the greatest number of opposing units. \nHowever, once a player chooses a sequence of captures, he must make all the captures possible in that sequence.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
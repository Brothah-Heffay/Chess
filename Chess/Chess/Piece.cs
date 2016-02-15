using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Piece
    {
        bool alive;
        int value; //pawn = 1, bishop and knight = 3, rook = 5, queen = 9, king = invaluable
        char repChar; //its character (letter) that it is represented by on the board
        string name;
        bool white; //controlled by the white player = true, black player = false

        public Piece(int v, char rc, string n, bool w)
        {
            alive = true;
            value = v;
            repChar = rc;
            name = n;
            white = w;
        }

        public char RepChar
        {
            get { return repChar; }
        }
    }
}

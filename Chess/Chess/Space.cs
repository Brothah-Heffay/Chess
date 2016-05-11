using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Space
    {
        bool occupied; //By a piece
        bool white; //False: Black; True: White  (color of space)
        bool attackedByWhite; //white has a piece that can move to this space (or this space is guarded by a white piece)
        bool attackedByBlack; //same as above for black
        Piece piece; //piece on space if (occupied == true)

        public Space(bool isWhite)
        {
            occupied = false;
            white = isWhite;
            attackedByWhite = false;
            attackedByBlack = false;
        }

        //Place a piece on this space
        public void setPiece(Piece p)
        {
            occupied = true;
            piece = p;
        }

        //Returns the space's char representation (of the piece on the space, or _  for blank)
        public char getSpaceChar()
        {
            if (occupied)
            {
                return piece.RepChar;
            }
            return '_'; //Space-holder for the character that represents a blank space (baby)
        }
    }
}

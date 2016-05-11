using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Bishop : Piece
    {
        bool whiteSpaced; //true = white-spaced bishop, false = black-spaced bishop

        public Bishop(bool isWhiteBishop, bool isWhitePlayers) : base(3, 'B', "Bishop", isWhitePlayers)
        {
            whiteSpaced = isWhiteBishop;
        }
    }
}

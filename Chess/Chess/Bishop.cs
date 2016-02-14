using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Bishop : Piece
    {
        bool whiteBishop; //true = white bishop, false = black bishop

        public Bishop(bool isWhite) : base(3, 'B', "Bishop")
        {
            whiteBishop = isWhite;
        }
    }
}

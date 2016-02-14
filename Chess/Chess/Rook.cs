using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Rook : Piece
    {
        bool hasMoved; //for castling

        public Rook(bool isWhitePlayers) : base(5, 'R', "Rook", isWhitePlayers)
        {
            hasMoved = false;
        }
    }
}

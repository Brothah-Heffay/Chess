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

        public Rook() : base(5, 'R', "Rook")
        {
            hasMoved = false;
        }
    }
}

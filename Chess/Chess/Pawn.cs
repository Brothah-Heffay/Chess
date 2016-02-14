using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Pawn : Piece
    {
        bool hasMovedTwoSpaces;
        bool hasReachedBackRank;

        public Pawn() : base(1, 'P', "Pawn")
        {
            hasMovedTwoSpaces = false;
            hasReachedBackRank = false;
        }
    }
}

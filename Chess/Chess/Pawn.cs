using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Pawn : Piece
    {
        bool hasMovedTwoSpaces;  //First move only
        bool hasReachedBackRank; //To promote

        public Pawn(bool isWhitePlayers) : base(1, 'P', "Pawn", isWhitePlayers)
        {
            hasMovedTwoSpaces = false;
            hasReachedBackRank = false;
        }
    }
}

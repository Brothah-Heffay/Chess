using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Knight : Piece
    {
        //The knight doesn't need any unique fields (yet)
        public Knight(bool isWhitePlayers) : base(3, 'N', "Knight", isWhitePlayers)
        { }

    }
}

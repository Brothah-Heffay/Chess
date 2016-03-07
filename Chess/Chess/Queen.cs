using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Queen : Piece
    {
        //Queen doesn't have any unique fields
        public Queen(bool isWhitePlayers) : base(9, 'Q', "Queen", isWhitePlayers)
        { }
    }
}

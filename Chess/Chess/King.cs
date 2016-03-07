using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class King : Piece
    {
        bool canMove; //if the king can move (if there is a space with no obstacles/guarded by other player)
        bool inCheck; //if the king is currently being attacked by an opponent's piece
                      
        //if canMove == false and inCheck == true, and 
        //your side can't take the checking piece or block the checking piece
        //then that king's side loses (Checkmate)

        public King(bool IsWhitePlayers) : base(0, 'K', "King", IsWhitePlayers)
        {
            canMove = false;
            inCheck = false;
        }
    }
}

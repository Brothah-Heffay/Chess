using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Player
    {
        bool whitePlayer; //white: true; black: false
        string name;
        List<Piece> capturedEnemyPieces = new List<Piece>();

        public Player(bool white, string playerName)
        {
            whitePlayer = white;
            name = playerName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Chess
    {
        Board board = new Board(); //Chess game has a board; the board has spaces; spaces have pieces on them
        Player[] players = new Player[2]; //Chess game has players
        bool gameOver = false;
        //Chess game also has all of the rules of movement, which are all of the methods in here
        
        public Chess(string name1, string name2)
        {
            players[0] = new Player(true, name1);
            players[1] = new Player(false, name2);
        }

        //How to move pieces?
        //pass a space on the board (from user input)
        //if there is a piece of the correct color there, get it's type (if not, ask again)
        //generate a list of all possible legal moves (spaces to move to) for that piece and see if the desired space is in that list
        //then ask the user for which space they want to move to if there are any legal moves for that piece (otherwise you can't move it)
        //Check for any checking complications or pinning, etc.
        //move the piece (either by creating a copy of the old piece, or by reassigning the same piece object to the new space)
        //update all fields and variables to the new piece arrangement (spaces' fields)
    }
}

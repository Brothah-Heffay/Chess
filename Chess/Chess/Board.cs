using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Board
    {
        Space[,] board = new Space[8,8];

        //Initializes a new board in the start game arrangement
        public Board()
        {
            //Fills the board with alternating black/white spaces with names representing their rank and file
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    char f = ' ';
                    switch(j)
                    {
                        case 0:
                            f = 'a';
                            break;
                        case 1:
                            f = 'b';
                            break;
                        case 2:
                            f = 'c';
                            break;
                        case 3:
                            f = 'd';
                            break;
                        case 4:
                            f = 'e';
                            break;
                        case 5:
                            f = 'f';
                            break;
                        case 6:
                            f = 'g';
                            break;
                        case 7:
                            f = 'h';
                            break;
                    }
                    bool white = true;
                    if ((i + j) % 2 == 1){ white = false; }
                    board[i, j] = new Space(white, f, 8 - i, "" + f + (8 - i));
                }
            }

            //Adds all of the game's pieces to the spaces that make up the board
            for (int i = 0; i < 8; i++) //for each of the 8 rows
            {
                for (int j = 0; j < 8; j++) //for each of the 8 columns
                {
                    if (i < 2) //in the top two rows (Black pieces)
                    {
                        if (i == 0)
                        {
                            if (j == 0 || j == 7) //Black rooks
                            {
                                board[i, j].setPiece(new Rook(false));
                            }
                            else if (j == 1 || j == 6) //Black Knights
                            {
                                board[i, j].setPiece(new Knight(false));
                            }
                            else if (j == 2 || j == 5) //Black Bishops
                            {
                                board[i, j].setPiece(new Bishop(j == 2 ? true : false, false));
                            }
                            else if (j == 3) //Black Queen
                            {
                                board[i, j].setPiece(new Queen(false));
                            }
                            else if (j == 4) //Black King
                            {
                                board[i, j].setPiece(new King(false));
                            }
                        }
                        if (i == 1) //Black Pawns
                        {
                            board[i, j].setPiece(new Pawn(false));
                        }
                    }
                    else if (i > 5) //Last two rows (white pieces)
                    {
                        if (i == 7) //if the bottom row
                        {
                            if (j == 0 || j == 7) //White Rooks
                            {
                                board[i, j].setPiece(new Rook(true));
                            }
                            else if (j == 1 || j == 6) //White Knights
                            {
                                board[i, j].setPiece(new Knight(true));
                            }
                            else if (j == 2 || j == 5) //White Bishops
                            {
                                board[i, j].setPiece(new Bishop(j == 2 ? false : true, true));
                            }
                            else if (j == 3) //White Queen
                            {
                                board[i, j].setPiece(new Queen(true));
                            }
                            else if (j == 4) //White King
                            {
                                board[i, j].setPiece(new King(true));
                            }
                        }
                        if (i == 6) //White Pawns
                        {
                            board[i, j].setPiece(new Pawn(true));
                        }
                    }
                }
            }
        } 

        public void display() //Displays the pieces on the board with their corresponding space characters
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(board[i, j].getSpaceChar());
                }
                Console.Write("\n");
            }

            //Shows the names of the spaces
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(board[i, j].Name + " ");
                }
                Console.Write("\n");
            }
        }
    }
}

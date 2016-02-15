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

        public Board()
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    bool white = true;
                    if ((i + j) % 2 == 1){ white = false; }
                    board[i, j] = new Space(white);
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i < 2)
                    {
                        if (i == 0)
                        {
                            if (j == 0 || j == 7)
                            {
                                board[i, j].setPiece(new Rook(false));
                                //Console.WriteLine("Black Rook");
                            }
                            else if (j == 1 || j == 6)
                            {
                                board[i, j].setPiece(new Knight(false));
                                //Console.WriteLine("Black Knight");
                            }
                            else if (j == 2 || j == 5)
                            {
                                board[i, j].setPiece(new Bishop(j == 2 ? true : false, false));
                                //Console.WriteLine("Black Bishop");
                            }
                            else if (j == 3)
                            {
                                board[i, j].setPiece(new Queen(false));
                                //Console.WriteLine("Black Queen");
                            }
                            else if (j == 4)
                            {
                                board[i, j].setPiece(new King(false));
                                //Console.WriteLine("Black King");
                            }
                        }
                        if (i == 1)
                        {
                            board[i, j].setPiece(new Pawn(false));
                            //Console.WriteLine("Black Pawn");
                        }
                    }
                    else if (i > 5)
                    {
                        if (i == 7)
                        {
                            if (j == 0 || j == 7)
                            {
                                board[i, j].setPiece(new Rook(true));
                                //Console.WriteLine("White Rook");
                            }
                            else if (j == 1 || j == 6)
                            {
                                board[i, j].setPiece(new Knight(true));
                                //Console.WriteLine("White Knight");
                            }
                            else if (j == 2 || j == 5)
                            {
                                board[i, j].setPiece(new Bishop(j == 2 ? false : true, true));
                                //Console.WriteLine("White Bishop");
                            }
                            else if (j == 3)
                            {
                                board[i, j].setPiece(new Queen(true));
                                //Console.WriteLine("White Queen");
                            }
                            else if (j == 4)
                            {
                                board[i, j].setPiece(new King(true));
                                //Console.WriteLine("White King");
                            }
                        }
                        if (i == 6)
                        {
                            board[i, j].setPiece(new Pawn(true));
                            //Console.WriteLine("White Pawn");
                        }
                    }
                }

            }
        } //Initializes a new board in the start game arrangement

        public void display() //Displays the pieces on the board
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(board[i, j].getSpaceChar());
                }
                Console.Write("\n");
            }
        }
    }
}

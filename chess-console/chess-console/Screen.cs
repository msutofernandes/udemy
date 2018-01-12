using System;
using board;
using chess;

namespace chessconsole
{
    class Screen
    {
        public static void printBoard(Board board) {

            for (int i = 0; i<board.rows; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j<board.columns; j++) {
                    printPiece(board.piece(i, j));
                }

                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void printBoard(Board board, bool[,] possiblePositions)
        {

            //ConsoleColor background = ConsoleColor.White;//Console.BackgroundColor;
            //ConsoleColor difBackground = ConsoleColor.DarkGray;

            for (int i = 0; i < board.rows; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.columns; j++) {
                    if (possiblePositions[i,j] == true) {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    } else {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    printPiece(board.piece(i, j));
                    Console.BackgroundColor = ConsoleColor.White;
                }

                Console.WriteLine();
                //Console.BackgroundColor = ConsoleColor.White;
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void printPiece(Piece piece){

            if (piece == null) {
                Console.Write("- ");
            } else {
                if (piece.color == Color.Black) {
                    Console.Write(piece);
                } else {
                    //ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(piece);
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.Write(" ");
            }


        }

        public static ChessPosition getChessPosition(){
            string s = Console.ReadLine();
            char column = s[0];
            int row = int.Parse(s[1] + "");
            return new ChessPosition(column, row);
        }
    }
}

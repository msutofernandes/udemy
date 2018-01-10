using System;
using board;

namespace chessconsole
{
    class Screen
    {
        public static void printBoard(Board board) {

            for (int i = 0; i<board.rows; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j<board.columns; j++) {
                    if (board.piece(i,j) == null) {
                        Console.Write("- ");
                    } 
                    else {
                        printPiece(board.piece(i, j));
                        Console.Write(" ");
                    }
                    
                }

                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void printPiece(Piece piece){
            if (piece.color == Color.Black){
                Console.Write(piece);
            } else {
                //ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(piece);
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }
    }
}

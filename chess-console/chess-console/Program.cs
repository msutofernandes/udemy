using System;
using board;
using chess;

namespace chessconsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            try {
                Board board = new Board(8, 8);

                board.addPiece(new Rook(board, Color.Black), new Position(0, 0));
                board.addPiece(new Rook(board, Color.Black), new Position(1, 3));
                board.addPiece(new King(board, Color.Black), new Position(0, 2));
                board.addPiece(new Rook(board, Color.White), new Position(3, 5));

                Screen.printBoard(board);
                
            } catch (BoardException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}

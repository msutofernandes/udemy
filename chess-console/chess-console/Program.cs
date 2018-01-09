using System;
using board;
using chess;

namespace chessconsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            board.addPiece(new King(board, 0), new Position(0,0));
            board.addPiece(new Rook(board, 0), new Position(7, 0));

            Screen.printBoard(board);
        }
    }
}

using board;
using System;

namespace chess
{
    class Rook : Piece
    {
        public Rook(Board board, Color color) : base(board, color)
        {
        }

        public override string ToString()
        {
            return "R";
        }

        private bool canMove(Position pos)
        {
            Piece p = board.piece(pos);
            return p == null || p.color != color;
        }

        public override bool[,] possibleMovements()
        {
            bool[,] array = new bool[board.rows, board.columns];

            Position pos = new Position(0, 0);

            //north
            pos.defineValues(position.row - 1, position.column);
            while (board.isPositionValid(pos) && canMove(pos)) {
                array[pos.row, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color) {
                    break;
                }
                pos.row = pos.row - 1;
            }

            //south
            pos.defineValues(position.row + 1, position.column);
            while (board.isPositionValid(pos) && canMove(pos))
            {
                array[pos.row, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }
                pos.row = pos.row + 1;
            }

            //east
            pos.defineValues(position.row, position.column + 1);
            while (board.isPositionValid(pos) && canMove(pos))
            {
                array[pos.row, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }
                pos.column = pos.column + 1;
            }

            //west
            pos.defineValues(position.row, position.column - 1);
            while (board.isPositionValid(pos) && canMove(pos))
            {
                array[pos.row, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }
                pos.column = pos.column - 1;
            }


            return array;
        }
    }
}

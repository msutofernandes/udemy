using board;
using System;

namespace chess
{
    class King : Piece
    {
        public King(Board board, Color color) : base(board, color) {
        }

        public override string ToString()
        {
            return "K";
        }

        private bool canMove(Position pos) {
            Piece p = board.piece(pos);
            return p == null || p.color != color;
        }

        public override bool[,] possibleMovements()
        {
            bool[,] array = new bool[board.rows, board.columns];

            Position pos = new Position(0, 0);

            //north
            pos.defineValues(position.row - 1, position.column);
            if (board.isPositionValid(pos) && canMove(pos)) {
                array[pos.row, pos.column] = true;
            }

            //ne
            pos.defineValues(position.row - 1, position.column + 1);
            if (board.isPositionValid(pos) && canMove(pos))
            {
                array[pos.row, pos.column] = true;
            }

            //east
            pos.defineValues(position.row, position.column + 1);
            if (board.isPositionValid(pos) && canMove(pos))
            {
                array[pos.row, pos.column] = true;
            }

            //se
            pos.defineValues(position.row + 1, position.column + 1);
            if (board.isPositionValid(pos) && canMove(pos))
            {
                array[pos.row, pos.column] = true;
            }

            //south
            pos.defineValues(position.row + 1, position.column);
            if (board.isPositionValid(pos) && canMove(pos))
            {
                array[pos.row, pos.column] = true;
            }

            //sw
            pos.defineValues(position.row + 1, position.column - 1);
            if (board.isPositionValid(pos) && canMove(pos))
            {
                array[pos.row, pos.column] = true;
            }

            //west
            pos.defineValues(position.row, position.column - 1);
            if (board.isPositionValid(pos) && canMove(pos))
            {
                array[pos.row, pos.column] = true;
            }

            //nw
            pos.defineValues(position.row - 1, position.column - 1);
            if (board.isPositionValid(pos) && canMove(pos))
            {
                array[pos.row, pos.column] = true;
            }

            return array;
        }
    }
}

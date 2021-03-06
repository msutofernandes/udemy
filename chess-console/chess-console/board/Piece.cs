﻿using System;
namespace board
{
    abstract class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int qtyMovements { get; protected set; }
        public Board board { get; protected set; }

        public Piece(Board board, Color color)
        {
            this.position = null;
            this.board = board;
            this.color = color;
            qtyMovements = 0;
        }

        public void increseQtyMovements(){
            qtyMovements++;
        }

        public abstract bool[,] possibleMovements();
    }
}

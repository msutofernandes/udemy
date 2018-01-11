﻿using System;
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

        public static ChessPosition getChessPosition(){
            string s = Console.ReadLine();
            char column = s[0];
            int row = int.Parse(s[1] + "");
            return new ChessPosition(column, row);
        }
    }
}

﻿using System;
using board;
using chess;

namespace chessconsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.White;

            try {
                ChessMatch match = new ChessMatch();

                while (!match.finishedMatch){

                    Console.Clear();
                    Screen.printBoard(match.board);

                    Console.Write("Origin: ");
                    Position origin = Screen.getChessPosition().toPosition();

                    bool[,] possiblePositions = match.board.piece(origin).possibleMovements();

                    Console.Clear();
                    Screen.printBoard(match.board, possiblePositions);

                    Console.Write("Destiny: ");
                    Position destiny = Screen.getChessPosition().toPosition();

                    match.doMovement(origin, destiny);
                }


                
            } catch (BoardException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using System;
using board;

namespace chessconsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Board b = new Board(8, 8);

            Position P;

            P = new Position(3, 4);

            Console.WriteLine("Posicao: " + P);
        }
    }
}

using System;
using board;
using chess;

namespace chessconsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            ChessPosition cp1 = new ChessPosition('a', 8);
            ChessPosition cp2 = new ChessPosition('h', 1);

            Console.WriteLine(cp1);
            Console.WriteLine(cp1.toPosition());
            Console.WriteLine(cp2);
            Console.WriteLine(cp2.toPosition());
        }
    }
}

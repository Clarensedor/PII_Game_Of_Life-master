using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Board gameBoard = new Board();
            BuildText.Printing(gameBoard);

        }
    }
}

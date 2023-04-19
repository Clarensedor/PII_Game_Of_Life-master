using System;
using System.Text;
using System.Threading;
using System.IO;

namespace PII_Game_Of_Life
{
    /// <summary>
    /// Imprimir es quien se encarga de imprimir la board en todo momento
    ///  solo hace eso por lo cual cumple con el principio SRP.
    /// </summary>
   public static class BuildText
    {
        public static void Printing(Board gameBoard)
        {
            int width = Board.width;
            int height = Board.heigth;
            while (true)
            {
                bool[,] b = gameBoard.gameBoard;
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(b[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Print.PrintString(s);
                gameBoard.NextGeneration();
            }
        }
    }
}
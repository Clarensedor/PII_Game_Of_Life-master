using System;
using System.Text;
using System.Threading;
namespace PII_Game_Of_Life
{
    public static class Print
    {
        public static void PrintString(StringBuilder s)
        {
            Console.WriteLine("\n");
            Console.WriteLine(s.ToString());
            Console.WriteLine("\n");
            Thread.Sleep(1000);
            
        }
    }
}
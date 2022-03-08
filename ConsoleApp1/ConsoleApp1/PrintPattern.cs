using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class PrintPattern
    {
        static void Main(string[] args)
        {
            int space = 0;
            int max = 5;

            for (var i = max; i > 0; i--)
            {
                for (var j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                for (var j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }

                for (var j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                space += 2;
            }
            Console.ReadLine();
        }
    }
}

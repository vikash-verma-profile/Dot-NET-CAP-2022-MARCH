using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Pattern3
    {
        static void Main(string[] args)
        {
            int max = 5;

            //This part is printing top level block
            for (var i = 1; i <= max; i++)
            {
                for (var j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (var k = i; k <= max; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //This part is printing lower level block
            for (var i = max; i >= 1; i--)
            {
                for (var j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (var k = i; k <= max; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

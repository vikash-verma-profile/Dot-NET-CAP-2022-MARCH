using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class PrintPattern
    {
        static void Main3(string[] args)
        {
            int space = 0;
            int max = 5;

            //this is runner 
            for (var i = max; i > 0; i--)
            {
                //this is printing Left side *  
                for (var j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                //this is creating spaces
                for (var j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                //this is priniting right side *'s
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

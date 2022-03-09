using System;
using System.Collections.Generic;
using System.Text;

namespace Keywords
{
    internal class _2Darrays
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[2, 2];//{ { 1, 2 },{ 3, 4 } };
            Console.WriteLine("Please enter Matrix values");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    array1[row, col]=Convert.ToInt32(Console.ReadLine());
                }
               
            }
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(array1[row,col]+"\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}

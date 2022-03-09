using System;
using System.Collections.Generic;
using System.Text;

namespace Keywords
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            //1d array
            int[] _1darr = new int[2];
            //2d array
            int[,] _2darr = new int[2,2];
            //jagged array
            int[][] arr = new int[2][];
            arr[0] = new int[2] { 1,2};
            arr[1] = new int[4] {41,42,43,44};
            for (int row = 0; row < arr.Length; row++)
            {
                for (int col = 0; col < arr[row].Length; col++)
                {
                    Console.Write(arr[row][col]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}

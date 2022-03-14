using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main1(string[] args)
        {

            /*
            //divide by zero exception
            //this block hold the code that may throw an exception
            try
            {
                int a = 0, b = 5;
                var c = b / a;
                Console.WriteLine(c);
                Console.WriteLine("Hello World!");
            }
            //this block catched the exception throw by the try block
            catch
            {
                Console.WriteLine("Some error occured");
            }
            */

            //out of index error
            //this block hold the code that may throw an exception
            try
            {
                //array of length 4
                int[] arr = { 1, 2, 3, 4 };
                //            0, 1, 2, 3
                //printed array 
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(i);
                }
                //printing an array element that is not there inside array we have defined
                Console.WriteLine(arr[5]);

                Console.WriteLine("Hello World!");
            }
            ////this block catched the exception throw by the try block
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                //Console.WriteLine("Some error occured");
            }
        }
    }
}

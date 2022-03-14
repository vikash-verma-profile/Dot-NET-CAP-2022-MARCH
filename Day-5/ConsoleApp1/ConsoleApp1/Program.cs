using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
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
                int[] arr = { 1, 2, 3, 4 };

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine(arr[5]);
                Console.WriteLine("Hello World!");
            }
            //this block catched the exception throw by the try block
            catch(Exception ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                //Console.WriteLine("Some error occured");
            }
        }
    }
}

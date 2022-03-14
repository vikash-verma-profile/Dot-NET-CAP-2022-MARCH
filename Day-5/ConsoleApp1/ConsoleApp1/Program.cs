using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}

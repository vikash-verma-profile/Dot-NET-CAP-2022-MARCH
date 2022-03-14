using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DivByZero : Exception
    {
        public DivByZero()
        {
            Console.WriteLine("Exception has occured");
        }
    }
    internal class CustomExceptions
    {
        public static double DivisionOperation(double numerator,double denominator)
        {
            if (denominator == 0)
            {
                throw new DivByZero();
            }
            return numerator / denominator;
        }
        static void Main4(string[] args)
        {
            int a = 6, b = 0;
            try
            {
                Console.WriteLine(DivisionOperation(a, b));
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

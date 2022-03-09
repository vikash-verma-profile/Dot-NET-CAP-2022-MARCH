using System;
using System.Collections.Generic;
using System.Text;

namespace Keywords
{
    internal class FunctionDemo
    {
        static void Sum(int a, int b)
        {
            //int a = 5, b = 5;
            Console.WriteLine("Sum in sum(): " + (a + b));
        }
        static void Main(string[] args)
        {
            int a=5,b=5;
            //Console.WriteLine("Sum in main()"+(a+b));
            Sum(a,b);
            Console.WriteLine("Hi i am back in Main");
        }
        //<function return type> function Name(<function-parameters>)
      
        //create a program to create a calculator
        //take choice from user enter use choice 1.ADD 2.SUB...
        //call function and do the manupulation and send response to black screen with the result 
    }
}

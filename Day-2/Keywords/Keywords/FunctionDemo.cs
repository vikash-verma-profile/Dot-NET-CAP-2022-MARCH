using System;
using System.Collections.Generic;
using System.Text;

namespace Keywords
{
    internal class FunctionDemo
    {
        static int Sum(int a, int b=5)//default parameter
        {
            //int a = 5, b = 5;
           return(a + b);
        }
        static int DefaultSum(int a, int b=6,int c=6)//default parameter or optional parameter
        {
            //int a = 5, b = 5;
            return (a + b);
        }
        static string sampleCall(int a,int c,int b=8)
        {
            return ("a= "+a.ToString()+",c= "+c.ToString()+", b= "+b.ToString());
        }
        static void Main2(string[] args)
        {
            Console.WriteLine(sampleCall(c:9,b:2,a:3));

            //int a=5,b=5;
            ////Console.WriteLine("Sum in main()"+(a+b));
            //int c=Sum(a);
            ////<parameter-name> : value
            //DefaultSum(c: 7, a: 9, b: 10);//named parameter
            //DefaultSum(a: 7, b: 9, c: 10);
            //Console.WriteLine("Sum is "+c);
        }
        //method parameters
        //Default parameter
        //named parameter
        //<function return type> function Name(<function-parameters>)
      
        //create a program to create a calculator
        //take choice from user enter use choice 1.ADD 2.SUB...
        //call function and do the manupulation and send response to black screen with the result 
    }
}

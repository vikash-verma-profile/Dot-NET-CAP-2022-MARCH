using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ConditionalStatements
    {
        static void Main(string[] args)
        {
            //int SampleNumber=Convert.ToInt32(Console.ReadLine());
            ////check a number is postive or negative and also check for whole number
            //if (SampleNumber > 0) //if your expression is true
            //{
            //    //then this part will run
            //    Console.WriteLine("Number is a postive number");
            //}
            //else if(SampleNumber==0)
            //{
            //    //in false case this part will run
            //    Console.WriteLine("Number is a Whole Number");
            //}
            //else
            //{
            //    Console.WriteLine("Number is a Negative Number");
            //}


            //int i;
            //Console.Write("Enter a Number : ");
            //i = int.Parse(Console.ReadLine());
            //if (i > 0 && i < 18)
            //{
            //    Console.Write("Entered age is not eligible for vote");
            //    Console.Read();
            //}
            //else if (i >= 18 && i < 60)
            //{
            //    Console.Write("Entered age is eligible for vote");
            //    Console.Read();
            //}
            //else
            //{
            //    Console.WriteLine("Persion is senior citizen");
            //    Console.Read();
            //}

            //?:
            //<expersion>?true:false;
            //if(){}else{}
            //()?{}:{}
           string meessage= (10 > 5) ? "Hi this is greater than 5" : "This is less than 5";
            Console.WriteLine(meessage);

        }
    }
}

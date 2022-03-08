using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ConditionalStatements
    {
        static void Main2(string[] args)
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

            //Console.WriteLine("Please enter some choice");
            //int WeekdayNumber=Convert.ToInt32(Console.ReadLine());
            ////switch
            //switch (WeekdayNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Today is Sunday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Today is Monday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Today is Tuesday");
            //        break;
            //    default:
            //        Console.WriteLine("Please enter the correct choice");
            //        break;
            //}

            //loops
            //for loop
            //while
            //do while
            //for each
            //for (<intialize part>;<conditional part>;<Increamet/decement>)
            Console.WriteLine("==========For Loop===============");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("==========while Loop===============");
            int j = 0;
            //Entry controlled loop
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }
            Console.WriteLine("==========Do While===============");
            //Exit controlled loop
            int k = 0;
            do 
            {
                Console.WriteLine(k);
                k++;
            } while (k < 5) ;
            Console.WriteLine("==========Nesting Loops===============");
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}

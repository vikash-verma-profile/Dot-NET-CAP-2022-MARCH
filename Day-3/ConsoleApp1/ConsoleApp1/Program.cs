using System;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            string sample = "Hi";//reserve a memory block to save HI value

            sample=sample+"Hello";//append in the same string
                                    //create a new memory block

            Console.WriteLine(sample);//it will create a new memory block for Hi+ Hello
            //immutable becuase we cannot change the value .any time we do the 

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hi");
            stringBuilder.Append("Hi Hello");//same memory block will be used for hi+Hi hello
            Console.WriteLine(stringBuilder);
        }
    }
}

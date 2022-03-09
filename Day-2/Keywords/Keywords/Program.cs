using System;

namespace Keywords
{
    internal class Program
    {
        //collection of homogeneous type of data
        static void Main1(string[] args)
        {
            //<data-type> [] <identfier>
            int[] Numbers;
            int[] NumbersList = {1,2,3,89,90,100};

            int length = NumbersList.Length;
            //6
            for (int index = 0; index < length; index++)
            {
                Console.WriteLine(NumbersList[index]);
            }


            Console.WriteLine("================For-Each========================");
            foreach (int item in NumbersList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================String Manupulation========================");
            string InputValue = "Vikash";
            for (int i = 0; i < InputValue.Length; i++)
            {
                Console.WriteLine(InputValue[i]);
            }
            foreach (var item in InputValue)
            {
                Console.WriteLine(item);

            }

            //create a program to check out of 10 numbers which are odd and even
            //write a program to reverse a string
            //write a program to check whether a string is palindrome or not "MADAM"==>MADAM  DAD ==>DAD
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class String_functions
    {
        public   static void Main()
        {

            //string 1 > string 2 ==>1
            //string 1 == string 2 ==>0 else it will return -1

            string cstring1 = "1234";
            string cstring2 = "1234";
            string cstring3 = "12345";
            Console.WriteLine(string.Compare(cstring1, cstring2));
            Console.WriteLine(string.Compare(cstring3, cstring2));
            Console.WriteLine(string.Compare(cstring2, cstring3));


            Console.WriteLine("=========== ===============");

            string sample = "Hi Vikash";
            string sample1 = "hello";

            string sample2 = "hello";
            string sample3 = "cshrap";

            string sample4 = "mello";
            string sample5 = "hello";
            //lowe case
            sample =sample.ToLower();
            Console.WriteLine("===========Lower case ===============");
            Console.WriteLine(sample);
            sample=sample.ToUpper();
            Console.WriteLine("===========Upper case ===============");
            Console.WriteLine(sample);
            Console.WriteLine("===========Compare case ===============");
            //var result=string.Compare(sample, sample2);
            Console.WriteLine(string.Compare(sample1, sample2)); //s1==s2 //0 when both length and content matches
            
            Console.WriteLine(string.Compare(sample2, sample3)); //  //1 when both length and content matches
            Console.WriteLine(string.Compare(sample3, sample4)); //-1when both length and content doesnot match matches
            Console.WriteLine(string.Compare(sample4, sample5)); //1
            //1
            //-1
            //0
        }
    }
}

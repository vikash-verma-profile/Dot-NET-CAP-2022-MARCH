using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class String_functions
    {
        public   static void Main3()
        {

            //string 1 > string 2 ==>1
            //string 1 == string 2 ==>0 else it will return -1

            string cstring1 = "1234";
            string cstring2 = "1234";
            string cstring3 = "12345";
            Console.WriteLine(string.Compare(cstring1, cstring2));//0
            Console.WriteLine(string.Compare(cstring3, cstring2)); //1
            Console.WriteLine(string.Compare(cstring2, cstring3)); //-1


            Console.WriteLine("=========== ===============");

            string sample = "Hi Vikash";
            string sample1 = "hello";

            string sample2 = "hello";
            string sample123 = "cshrap";

            string sample4 = "mello";
            string sample5 = "hello";
            //lowe case
            //sample =sample.ToLower();
            //Console.WriteLine("===========Lower case ===============");
            //Console.WriteLine(sample);
            //sample=sample.ToUpper();
            //Console.WriteLine("===========Upper case ===============");
            //Console.WriteLine(sample);
            //Console.WriteLine("===========Compare case ===============");
            //var result=string.Compare(sample, sample2);
            //Console.WriteLine(string.Compare(sample1, sample2)); //s1==s2 //0 when both length and content matches
            Console.WriteLine("=========== ===============");
            //Console.WriteLine(sample2.Length);
            //Console.WriteLine(sample123.Length);
            Console.WriteLine("=========== ===============");
            //Console.WriteLine(sample2.Length> sample123.Length?1:-1);
            Console.WriteLine(string.Compare("Hello1", "Hello")); //firststring > second string 1
            Console.WriteLine(string.Compare("Hello", "Hello1"));//firststring < second string -1

            Console.WriteLine("=========== ===============");
            ////  //1 when both length and content matches
            //Console.WriteLine(string.Compare(sample3, sample4)); //-1when both length and content doesnot match matches
            //Console.WriteLine(string.Compare(sample4, sample5)); //1
            //1
            //-1
            //0
        }
    }
}

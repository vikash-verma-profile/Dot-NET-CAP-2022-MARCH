using System;
using System.Collections.Generic;
using System.Text;

namespace Keywords
{
    //Call by value
    //Call by reference
    internal class CallByValuueandcallByreference
    {
        static void Main4(string[] args)
        {
            int a=2, b = 3;
            Console.WriteLine("Value of a= {0} and b={1} before swapping",a,b);
            Swap( ref a, ref b);
            Console.WriteLine("Value of a= {0} and b={1} after swapping", a, b);
            string result;

            OutDemo("23", out result);
            Console.WriteLine("Value after calling function  : "+result);
        }
        static void Swap(ref int a,ref int b)
        {
            int c;
            c= a;
            a= b;
            b= c;
            Console.WriteLine("Value of a= {0} and b={1} after swapping in Swap function", a, b);
        }
        static void OutDemo(string inputvalue,out string outputvalue)
        {
            outputvalue= inputvalue+"  Hi !";
        }
    }
}

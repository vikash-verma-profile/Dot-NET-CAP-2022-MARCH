using System;
using System.Collections.Generic;
using System.Text;

namespace Keywords
{
    internal class BoxandUnBox
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================Boxing=====================");
            int num = 20;
            //boxing
            object obj = num;//Line for Boxing
            //Stack===>heap 

            Console.WriteLine(obj);
            Console.WriteLine("==================UnBoxing=====================");
            num = 100;
            Console.WriteLine(num);

            //Heap===>Stack 
            //unboxing
            num = (int)obj;//Line for UnBoxing



            Console.WriteLine(num);
        }
    }
}

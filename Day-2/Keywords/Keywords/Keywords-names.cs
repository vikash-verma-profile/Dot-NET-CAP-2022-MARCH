using System;
using System.Collections.Generic;
using System.Text;

namespace Keywords
{
    internal class Keywords_names
    {
        static void Main3(string[] args)
        {
            //var and dynamic keyword
            //var was a compile time variable
            //var i = 1;
            //Console.WriteLine(typeof(int));
            //Console.WriteLine(i.GetType());
            // i = "Vikash";
            //Console.WriteLine(i);
            dynamic i = 1;
            Console.WriteLine(i.GetType());
            i = "Vikash";
            Console.WriteLine(i.GetType());
            Console.WriteLine(i);


        }
    }
}

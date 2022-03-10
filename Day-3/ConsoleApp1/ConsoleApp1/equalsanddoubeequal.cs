using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class equalsanddoubeequal
    {
        static void Main(string[] args)
        {
            string name = "Vikash";
            string myname = name;
            Console.WriteLine(name == myname);//True
            Console.WriteLine(name.Equals(myname));//True
            Console.WriteLine("=====================================");
            object oname = "Vikash";
            char[] values = { 'V', 'i', 'k', 'a', 's', 'h' };
            object omyname = new string(values);
            Console.WriteLine(oname == omyname);//false this is maching the refernces 
            Console.WriteLine(omyname.Equals(oname));//True this is maching the content 
        }
    }
}

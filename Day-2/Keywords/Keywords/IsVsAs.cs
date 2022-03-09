using System;
using System.Collections.Generic;
using System.Text;

namespace Keywords
{
    class Class1
    {

    }
    class Class2
    {

    }
    internal class IsVsAs
    {

        public static void Test(object o)
        {
            if(o is Class1)
            {
                Console.WriteLine("o is Class1");
            }
            else if(o is Class2)
            {
                Console.WriteLine("o is class2");
            }
        }
        static void Main(string[] args)
        {
            //is and as

            //is is used when you want to check something 

            //as will be used when you want to some conversion or type casting
            Class1 c1=new Class1();
            Class2 c2 = new Class2();
            Test(c1);
            Test(c2);

            object[] myobjects=new object[2];
            myobjects[0] = new Class1();
            myobjects[1] = "Vikash";

            foreach (var item in myobjects)
            {
                string s=item as string;
                if (s != null)
                {
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine("Not a string value");
                }
            }
        }
    }
}

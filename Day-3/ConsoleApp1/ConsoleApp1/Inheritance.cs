using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //parent class // base class
    class A
    {
        public int a,b;
       
    }
    //child class //dervied class
    class B:A
    {
        public int c;
    }
    internal class Inheritance
    {
        public static void Main()
        {
            B b=new B();
            b.a = 1;
            b.b = 2;
            b.c = 3;
            Console.WriteLine("a="+b.a+"b="+b.b+"c="+b.c);
        }
    }
}

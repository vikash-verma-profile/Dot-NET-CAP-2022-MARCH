using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //single level inheritnace
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
    class C:B
    {
        public int d;
    }
    internal class Inheritance
    {
        public static void Main6()
        {
            C b=new C();
            b.a = 1;
            b.b = 2;
            b.c = 3;
            b.d = 4;
            Console.WriteLine("a="+b.a+"b="+b.b+"c="+b.c+"d="+ b.d);
        }
    }
}

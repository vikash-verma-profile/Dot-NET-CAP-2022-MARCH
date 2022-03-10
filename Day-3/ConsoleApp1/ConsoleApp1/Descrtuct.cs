using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    //this
    //access modifiers

    //private ,public ,protected,internal ,protected internal

    //private=>

     class Sample
    {
        protected int a;
        public Sample()
        {

        }
        public Sample(int a)
        {
            this.a= a;
        }
        public void Display()
        {
            Console.WriteLine("a= "+a);
        }
        ~Sample()
        {

        }
    }
    class Sample2 : Sample
    {
        public void Dispalay2()
        {
            Console.WriteLine(a);
        }
    }
    internal class Descrtuct
    {
        public static void Main8()
        {
            Sample s =new Sample(1);
            s.Display();
        }
    }
}

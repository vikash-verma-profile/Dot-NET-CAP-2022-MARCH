using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //abstract==> abstract==>interface
    //abstract class can have abstract as well as non-abstract members 
    abstract class AbstarctClassSample
    {
        abstract public void sum();
    }

    class SampleDerivedClass:AbstarctClassSample
    {
        public override void sum()
        {
            Console.WriteLine();
        }
    }
    //by default all the members in the interface are abstract
    //interface=>
    interface IA
    {
        void sum();
    }
    internal class Interfaces:IA
    {
        public void sum()
        {

        }
        public static void Main8()
        {

        }
    }

    class A
    {

    }
    class B:A
    {

    }
    class C:A
    {

    }
    //class D : B,C
    //{

    //}

    interface IAa
    {
        void sum();
    }
    interface IB
    {
        void Print();
    }
    class Dd:IAa,IB
    {
        public void sum()
        {

        }
        public void Print()
        {

        }
    }
}

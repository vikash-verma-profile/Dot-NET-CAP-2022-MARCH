using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Method OverLoading
    internal class Polymorphism
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Add(int a,int b,int c)
        {
            return a+b+c;
        }
        static void Main(string[] args)
        {
            Polymorphism polymorphism = new Polymorphism(); 
            Console.WriteLine(polymorphism.Add(1,1));
            Console.WriteLine(polymorphism.Add(2,2,3));  
        }
    }
}

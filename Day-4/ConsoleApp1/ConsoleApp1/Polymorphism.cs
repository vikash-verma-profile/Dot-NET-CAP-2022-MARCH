using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Method OverLoading
    internal class Polymorphism
    {
        //1.Using different Data-Types in Parameters
        //2.Using Differnet Number of parameters

        //3.Name should be same of the function that are getting overloaded
        public int Add(int a,int b)
        {
            return a + b;
        }
        //example of 2 creteria
        public int Add(int a,int b,int c)
        {
            return a+b+c;
        }
        //example of 1 creteria
        public string Add(string a,string b)
        {
            return a + b;
        }
        static void Main2(string[] args)
        {
            Polymorphism polymorphism = new Polymorphism(); 
            Console.WriteLine(polymorphism.Add(1,1));
            Console.WriteLine(polymorphism.Add("1", "1"));
            Console.WriteLine(polymorphism.Add(2,2,3));  
        }
    }
}

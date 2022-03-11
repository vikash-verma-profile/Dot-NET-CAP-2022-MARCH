using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    sealed class SeleadBaseClass
    {

    }
    //class SeleadDerivedClass: SeleadBaseClass
    //{

    //}

    abstract class AbstractBaseClass
    {
        abstract public void show();
    }
    class AbstractDerivedClass:AbstractBaseClass
    {
        public override void show()
        {
            Console.WriteLine("hi");
        }
    }
    internal class AbstractvsSealed
    {


        public static void Main5()
        {
            //AbstractBaseClass o=new AbstractBaseClass();
            SeleadBaseClass o1=new SeleadBaseClass();
            AbstractDerivedClass o=new AbstractDerivedClass();  
            o.show();
        }

















        //a class obhect cannot be created but we can inherit the class
        //abstraction

        //sealed 
        //if a class is sealed you cannot inherit that class but you can create a object of that class
        sealed class Sample3
        {

        }
        //class Sample4 : Sample3
        //{

        //}
        abstract class Sample
        {
            abstract public void show();
            public void Print()
            {
                Console.WriteLine(" I am an abstract class");
            }
        }
        class Sample1 : Sample
        {
            public override void show()
            {
                Console.WriteLine("Hi");
            }
        }
        //public static void Main()
        //{
        //    Sample3 sample1 = new Sample3();
        //    Sample1 sample = new Sample1();
        //    sample.Print();
        //}

        /*abstract ==> you cannot create an object but you can inherit
if you make any function as abstract then you cannot define in the same class
class who is derived from base class have to give the defination of abstract function defined in the base class

sealed==>you can create an object but you cannot inherit
*/
    }
}


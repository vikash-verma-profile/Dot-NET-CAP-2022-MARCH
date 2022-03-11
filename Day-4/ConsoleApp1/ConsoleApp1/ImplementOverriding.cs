using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Overriding

    //virtual Keyword

    //override

    public class BaseClass
    {
        public virtual void Show()
        {
            Console.WriteLine("Base Class");
        }

    }
    public class DerivedClass:BaseClass
    {
        public override void Show()
        {
            Console.WriteLine("Derived Class");
        }
    }
    internal class ImplementOverriding
    {
        public static void Main4()
        {
            BaseClass baseClass=new BaseClass();
            baseClass.Show();

            baseClass=new DerivedClass();
            baseClass.Show();
        }
    }
}

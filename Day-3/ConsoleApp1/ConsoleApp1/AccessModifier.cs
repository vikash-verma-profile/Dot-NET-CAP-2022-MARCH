using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class dummy1
    {
        protected int a;
    }
    class dummy2:dummy1
    {
        public void show()
        {
            Console.WriteLine(a);
        }
    }
    internal class AccessModifier
    {
        public static void Main8()
        {
            dummy1 dummy2 = new dummy1();
            //dummy2.a=2;
        }
    }
}

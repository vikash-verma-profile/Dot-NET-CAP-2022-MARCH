using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //Enumeration
    //value type
    enum month
    {
        jan,
        feb,
        mar,
        apr,
        may
    }
    enum Gender
    {
        Male=4,
        Female=2,
        Other=3
    }
    internal class EnumExample
    {
        public static void Main10()
        {
            Console.WriteLine((int)month.jan);
            Console.WriteLine((int)month.feb);
            Console.WriteLine(Gender.Male);
            Console.WriteLine((int)Gender.Male);
        }
    }
}

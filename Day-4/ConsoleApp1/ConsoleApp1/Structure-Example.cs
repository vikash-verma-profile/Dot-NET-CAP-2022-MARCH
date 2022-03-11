using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    struct SampleStruct
    {
        //Fields
        //Parameterized constructor
        //constants
        //properties
        //Events
        //Methods
    }

    struct PersonStruct
    {
        public string Name;
        public int Age;
        public int Weight;
    }
    internal class Structure_Example
    {
        public static void Main()
        {
            //create an reference variable of struct
            PersonStruct personStruct;
            personStruct.Weight = 80;
            personStruct.Age = 21;
            personStruct.Name = "Vikash Verma";
            Console.WriteLine(personStruct.Name);
            Console.WriteLine(personStruct.Age);
            Console.WriteLine(personStruct.Weight);

        }
    }
}

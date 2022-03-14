using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class PRobelm_Struct
    {
        struct EmployeeStruct
        {
            public int ID;
            public string Name;
            public int Age;
        }
        internal class Employee_Example
        {
            public static void Main()
            {
                //create an reference variable of struct
                EmployeeStruct employeeStruct;
                employeeStruct.ID = 78;
                employeeStruct.Name = "Aaradhana nayak";
                employeeStruct.Age = 22;
                Console.WriteLine(employeeStruct.ID);
                Console.WriteLine(employeeStruct.Name);
                Console.WriteLine(employeeStruct.Age);
                Console.ReadLine();
            }
        }
    }
}


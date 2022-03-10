using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class student
    {
        //constuctor
        int age,roll_no;
        string name;
        public student(int _rollno,string _name,int _age)
        {
            age = _age;
            roll_no = _rollno;
            name = _name;
        }
        public void Display()
        {
            Console.WriteLine("Student Details are :-");
            Console.WriteLine("Student Name : " + name);
            Console.WriteLine("Student Roll No : " + roll_no);
            Console.WriteLine("Student Age : " + age);
        }
    }
    internal class ConstructorvsDesctructor
    {
        public static void Main()
        {
            student student = new student(101,"Raj",14);
            student.Display();
        }
    }
}

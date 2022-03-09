using System;
using System.Collections.Generic;
using System.Text;

namespace Keywords
{

    class Student
    {
        //fields
        //abstraction

        //contructor
        //private constructor
        //copy constructor
        //default constructor
        //parmetized constructor
        //static constructor
        
        
        //default
        Student()
        {

        }
       public Student(int _age)
        {
            age = _age;
        }
        int age;
        //methods
        public void display()
        {
            Console.WriteLine(age);
            Console.WriteLine(studentname);
        }

        //staring from here
        string _name;
        public string GetName()
        {
            return _name;
        }
        public void SetAge(string name)
        {
            _name = name;
        }
        //ENding 

        //properties
        public string studentname {  get;  set; }
    }
    internal class SampleClass
    {
        static void Main(string[] args)
        {
            Student student = new Student(1);
            //student.a = 1;
            student.studentname = "Vikash";
           // Console.WriteLine(student.studentname);
            student.display();
            //Console.WriteLine(student.a);
        }
    }
}

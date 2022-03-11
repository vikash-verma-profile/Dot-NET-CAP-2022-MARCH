using System;

namespace ConsoleApp1
{
    class Person
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Hello !");
        }
        public void SetAge(int age)
        {
            this.age = age;
        }

    }
    class Student:Person
    {
        public void Study()
        {
            Console.WriteLine("I am Studying");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years old",age);
        }

    }
    class Teacher:Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();   
            person.Greet();

            Student student = new Student();
            student.SetAge(20);
            student.Greet();
            student.ShowAge();

            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Greet();
            teacher.Explain();
        }
    }
}

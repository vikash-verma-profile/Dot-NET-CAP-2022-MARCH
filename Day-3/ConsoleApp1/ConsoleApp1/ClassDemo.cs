using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {
        public int StudentRollNo { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public int StudentAge { get; set; }

        public void GetStudentData()
        {
            Console.WriteLine("Please enter student Roll Number");
            StudentRollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter student Name");
            StudentName = Console.ReadLine();
            Console.WriteLine("Please enter student Address");
            StudentAddress = Console.ReadLine();
            Console.WriteLine("Please enter student Age");
            StudentAge = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayStudentData()
        {
            Console.WriteLine("Student Details are :-");
            Console.WriteLine("Student Name : " + StudentName);
            Console.WriteLine("Student Roll No : " + StudentRollNo);
            Console.WriteLine("Student Address : " + StudentAddress);
            Console.WriteLine("Student Age : " + StudentAge);
        }
    }
    internal class ClassDemo
    {
        public static void Main()
        {
            Student[] studentList = new Student[2];
            int i = 0;
            foreach (Student item in studentList)
            {
                var student = new Student();
                student.GetStudentData();
                studentList[i] = student;
                i++;
            }
            foreach (var item in studentList)
            {
                item.DisplayStudentData();
            }
        }
    }
}

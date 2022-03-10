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
        //public student(int _rollno,string _name,int _age)
        //{
        //    age = _age;
        //    roll_no = _rollno;
        //    name = _name;
        //}
        public int getStudentRollno()
        {
            return roll_no;
        }
        public void Display()
        {
            Console.WriteLine("Student Details are :-");
            Console.WriteLine("Student Name : " + name);
            Console.WriteLine("Student Roll No : " + roll_no);
            Console.WriteLine("Student Age : " + age);
        }
        public void GetStudentData()
        {
            Console.WriteLine("Please enter student Roll Number");
            roll_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter student Name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter student Age");
            age = Convert.ToInt32(Console.ReadLine());
        }
        public static student[] DeleteStudent(student[] studentsList,int _droll_no)
        {
            student[] OstudentList = new student[5];
            int index = 0;
            foreach (var item in studentsList)
            {
                if (item != null)
                {
                    if (!(item.getStudentRollno() == _droll_no))
                    {
                        OstudentList[0] = item;
                        index++;
                    }
                }
               
            }
            return OstudentList;
        }
    }
    internal class ConstructorvsDesctructor
    {
        public static void Main()
        {
            //student student = new student(101,"Raj",14);

            //student.Display();
            student []studentList = new student[5];
            int index = 0;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please enter your choice:- \n 1.Create \n 2.Delete \n 3.List \n 4.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var student = new student();
                        student.GetStudentData();
                        studentList[index] = student;
                        index++;
                        break;
                    case 2:
                        Console.WriteLine("Please enter student roll_no that you want to delete");
                        int _deleteroll_no = Convert.ToInt32(Console.ReadLine());
                        studentList = student.DeleteStudent(studentList, _deleteroll_no);
                        break;
                    case 3:
                        foreach (var item in studentList)
                        {
                            if (item != null)
                            {
                                item.Display();
                            }
                        }
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        break;
                }
            }
           
        }
    }
}

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Line 1");
            Console.WriteLine("Line 2");

            //Arithmatic operators
            //Comments
            //==> single line comment

            /*
             ==> multi line comment
            asdasd
            asdasd
            asdasd
            asdasdasd
            asdasd

             */
            Console.WriteLine("============Arithmatic Operator===========================");
            Console.WriteLine(1+2);
            Console.WriteLine(1-2);
            Console.WriteLine(1*2);
            Console.WriteLine(4/2);
            Console.WriteLine(4%2);
            Console.WriteLine("============Assigment Operator and Variables===========================");
            // <data-type> <variable-name>
            int a;//How we declare a variable
            a = 2;//we are using an assignment operator
            int Number1, Number2;
            Number1 = 6;
            Number2 = 2;
            Console.WriteLine(Number1 + Number2);
            Console.WriteLine(Number1 - Number2);
            Console.WriteLine(Number1 * Number2);
            Console.WriteLine(Number1 / Number2);
            Console.WriteLine(Number1 % Number2);
            Console.WriteLine("============Comparision Operator===========================");
            // ==  ===> LHS=RHS Equal to
            //Not equal !=
            //>
            //<
            //>=
            //<=
            Console.WriteLine(Number1==Number2);//false Boolean
            Console.WriteLine(Number1!= Number2);
            Console.WriteLine("============Logical Operator===========================");
            /*
             * && Logical And   (Exp1 AND EXP2) if both are
             * TRUE AND TRUE ==>TRUE
             * TRUE AND FALSE ==>FALSE
             * FALSE AND TRUE ==>FALSE
             * FALSE AND FALSE ==>FALSE
             * || Logical OR (Exp1 OR EXP2) if both are
             * TRUE AND TRUE ==>TRUE
             * TRUE AND FALSE ==>TRUE
             * FALSE AND TRUE ==>TRUE
             * FALSE AND FALSE ==>FALSE
             * ! Logical NOT
             * !(Exp) if 
             * !(True)=>false
             * !(False)=>true
            */
            Console.WriteLine((Number1 == Number2)&&(Number1 != Number2));//false Boolean
            Console.WriteLine((Number1 == Number2) || (Number1 != Number2));//true
            Console.WriteLine(!(Number1 == Number2));//true
            Console.WriteLine("============Type casting and taking input from user===========================");
            Console.WriteLine("Please enter some Value:-");
            string Dummy=Console.ReadLine();
            Console.WriteLine("Please enter integer value:-");
            int InputNumber = Convert.ToInt32(Console.ReadLine()); //string
            //type mismatch 
            //type casting
            Console.WriteLine("The value entered by user is "+Dummy);
            Console.WriteLine("after converting to int " + InputNumber);
            Console.WriteLine("============Conditional Statements and Terrnary Operator===========================");

            //check a number is greater than 5 or not
            if (InputNumber > 5) //if your expression is true
            {
                //then this part will run
                Console.WriteLine("Number is greater than 5");
            }
            else
            {
                //in false case this part will run
                Console.WriteLine("Number is less than 5");
            }
        }
    }
}

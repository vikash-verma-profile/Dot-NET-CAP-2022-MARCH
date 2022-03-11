using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   abstract class Animal
    {
        private string Name;
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public abstract void Eat();

    }
    class Dog:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
    internal class PracticeProblem
    {
        public static void Main6()
        {
            Dog dog=new Dog();
            dog.SetName(Console.ReadLine());
            Console.WriteLine(dog.GetName());
            dog.Eat();
        }
    }
}

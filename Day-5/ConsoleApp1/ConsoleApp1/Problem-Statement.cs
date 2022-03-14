using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    interface IVehiculo
    {
        void Drive();
        bool Refuel(int amount);
    }
    class Car:IVehiculo
    {
        public int Fuel { get; set; }
        public Car(int fuel)
        {
            Fuel = fuel;
        }
        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving");

            }
            else
            {
                Console.WriteLine("No fuel");
            }
        }

        public bool Refuel(int amount)
        {
            Fuel = Fuel + amount;
            return true;
        }
    }
    internal class Problem_Statement
    {
        static void Main(string[] args)
        {
            Car car= new Car(0);
            int fuel=int.Parse(Console.ReadLine());
            if (car.Refuel(fuel))
            {
                car.Drive();
            }
        }
    }
}

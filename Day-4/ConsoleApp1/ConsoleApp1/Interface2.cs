using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Vehicle
    {
        //all are abstract methods
        void changeGear(int a);
        void SpeedUp(int a);
        void ApplyBreaks(int a);
    }

    class Bicycle : Vehicle
    {
        //class fields
        int speed;
        int gear;
        public void changeGear(int newgear)
        {
            gear = newgear;
        }
        public void SpeedUp(int increment)
        {
            speed = speed+ increment;
        }
        public void ApplyBreaks(int decrement)
        {
            speed=speed-decrement;
        }
        public void PrintCurrentState()
        {
            Console.WriteLine("Speed :" + speed + "Gear :" + gear);
        }
    }
    class Bike : Vehicle
    {
        //class fields
        int speed;
        int gear;
        public void changeGear(int newgear)
        {
            gear = newgear;
        }
        public void SpeedUp(int increment)
        {
            speed = speed + increment;
        }
        public void ApplyBreaks(int decrement)
        {
            speed = speed - decrement;
        }
        public void PrintCurrentState()
        {
            Console.WriteLine("Speed : " + speed + "Gear : " + gear);
        }
    }
    internal class Interface2
    {
        public static void Main()
        {
            Bicycle bicycle = new Bicycle();
            bicycle.changeGear(2);
            bicycle.SpeedUp(3);
            bicycle.ApplyBreaks(1);

            Console.WriteLine("Bicycle Present state");
            bicycle.PrintCurrentState();

            Bike bike = new Bike();
            bike.changeGear(2);
            bike.SpeedUp(3);
            bike.ApplyBreaks(1);

            Console.WriteLine("Bike Present state");
            bike.PrintCurrentState();


        }
    }
}

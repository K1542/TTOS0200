using System;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one car instance
            Car datsun = new Car();
            datsun.Model = "Datsun 100A";
            datsun.Color = "red";
            datsun.Engine = 1.0;
            datsun.Speed = 0;
            datsun.FuzzyDices = true;
            datsun.DoorCount = 2;
            // display car data
            datsun.PrintData();
            Console.ReadLine();
            // accelerate, change car's speed value
            datsun.Accelerate();
            // display car data again, notice changed speed value!
            datsun.PrintData();
            Console.ReadLine();
        }
    }
}
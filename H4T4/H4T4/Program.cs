using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike1 = new Bike();
            bike1.Name = "Jopo ";
            bike1.Model = "Street ";
            bike1.Year = 2018;
            bike1.Color = " Pink ";
            bike1.Gear = false;
            Console.WriteLine(bike1.ToString());
            Bike bike2 = new Bike();
            bike2.Name = "Yamaha ";
            bike2.Model = "BMX ";
            bike2.Year = 2012;
            bike2.Color = " Purple ";
            bike2.Gear = true;
            bike2.GearName = " Gearimus Maximus ";
            Console.WriteLine(bike2.ToString());
            Boat boat1 = new Boat();
            boat1.Name = "Anna ";
            boat1.Model = "6000 ";
            boat1.Year = 2020;
            boat1.Color = "White";
            boat1.Type = "Purjevene ";
            boat1.Seats = 20;
            Console.WriteLine(boat1.ToString());
            Vehicle car = new Vehicle();
            car.Name = "Toyota ";
            car.Model = "Corolla ";
            car.Year = 1988;
            car.Color = "Red";
            Console.WriteLine(car.ToString());
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
    }
}
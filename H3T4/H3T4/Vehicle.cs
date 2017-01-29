using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3T4
{
    class Vehicle
    {
        public static string Name = "Toyota";
        public int Tyres { get; set; }
        public int Speed { get; set; }
        private string[] strings = new string[100];
        public void Accelerate()
        {
            Speed += 5;
        }
        public void Brake()
        {
            Speed -= 5;
        }
        public void PrintData()
        {
            Console.WriteLine("Car data : ");
            Console.WriteLine("- model : " + Name);
            Console.WriteLine("- Tyres : " + Tyres);
            Console.WriteLine("- speed : " + Speed);
        }
        ~Vehicle()
        {
            Console.WriteLine("Car object destroyed.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Speed = 160;
            vehicle.Tyres = 4;

            vehicle.PrintData();
            Console.ReadLine();

            vehicle.PrintData();
            Console.ReadLine();
        }
    }
}

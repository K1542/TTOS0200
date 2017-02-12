using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            bool result;
            do
            {
                Console.WriteLine("Elevator is now in floor: " + elevator.Floor);
                Console.WriteLine("Where you wanna go? ");
                string line = Console.ReadLine();
                int floor;
                result = int.TryParse(line, out floor);
                if (result)
                {
                    elevator.Floor = floor;
                }
            } while (result);
            Console.WriteLine("U on floor: " + elevator.Floor);
            Console.ReadLine();
        }
    }
}

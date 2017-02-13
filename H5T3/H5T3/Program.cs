using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5T3
{
    class Program
    {
        static void Main()
        {
            Company company = new Company();
            while (true)
            {
                int selection = -1;
                Console.Write("1. Hire. 2. Fire. 3. List 0. Quit: ");
                bool status = int.TryParse(Console.ReadLine(), out selection);
                if (status)
                {
                    switch (selection)
                    {
                        case 0:
                            return;
                        case 1:
                            Console.Write("Give name for new worker: ");
                            string name = Console.ReadLine();
                            company.AddEmployee(name);
                            break;
                        case 2:
                            company.FireLast();
                            break;
                        case 3:
                            company.PrintData();
                            break;

                        default:
                            Console.WriteLine("Please choose a number between 0 and 3");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("You must give number");
                }
            }
        }
    }
}

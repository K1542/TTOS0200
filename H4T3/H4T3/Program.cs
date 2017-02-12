using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Kirsi Kermit ";
            employee.Profession = "Teacher ";
            employee.Salary = 3000;
            Console.WriteLine(employee.ToString());
            Boss boss = new Boss();
            boss.Name = "Ari Rantala ";
            boss.Profession = "Headmaster ";
            boss.Salary = 9001;
            boss.Car = "Lamborghini ";
            boss.Bonus = 2000;
            Console.WriteLine(boss.ToString());
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
    }
}

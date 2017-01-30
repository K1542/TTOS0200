using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4T3
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public double Salary { get; set; }

        public Employee()
        {

        }
        public Employee(string name, string profession,double salary)
        {
            Name        = name;
            Profession  = profession;
            Salary      = salary;
        }

        public override string ToString()
        {
            return "Name: " + Name + "Profession: " + Profession + "Salary: " + Salary;
            
        }




    }
}

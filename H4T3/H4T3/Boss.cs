using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4T3
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public double Bonus { get; set; }

        public Boss()
        {

        }
        public Boss(string name, string profession, double salary, string car, double bonus): base(name, profession, salary)
        {
            Car = car;
            Bonus = bonus;
        }

        public override string ToString()
        {
            return base.ToString() + "Car: " + Car + "Bonus: " + Bonus;

        }




    }
}
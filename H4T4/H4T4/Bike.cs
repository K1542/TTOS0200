using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4T4
{
    class Bike : Vehicle
    {
        public bool Gear { get; set; }
        public string GearName{ get; set; }

        public Bike()
        {

        }
        public Bike(string name, string model, int year, string color, bool gear, string gearname) : base(name, model, year, color)
        {
            Gear = gear;
            GearName = gearname;
            Gear.ToString();
        }

        public override string ToString()
        {
            if (Gear == true)
            {
                return base.ToString() + "Gear: " + Gear + " Gear name: " + GearName;
            }
            else
            {
                return base.ToString() + "Gear: " + Gear;
            };
            

        }




    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4T4
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public Vehicle()
        {

        }
        public Vehicle(string name, string model, int year, string color)
        {
            Name = name;
            Model = model;
            Year = year;
            Color = color;
        }

        public override string ToString()
        {
            return "Name: " + Name + "Model: " + Model + "Year: " + Year + "Color: " + Color;

        }




    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.RadioOn = true;
            radio.HZ = 2666.7;
            radio.Volume = 9;
            Console.WriteLine(radio.ToString());
            Console.ReadLine();
        }
    }
}
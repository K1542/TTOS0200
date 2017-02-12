using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4T2
{
    class Amp
    {
        private const int minVol = 0;
        private const int maxVol = 100;
        private int vol = 50;

        public int volume
        {
            get
            {
                return vol;
            }
            set
            {
                if (value < minVol)
                {
                    Console.WriteLine("Too low volume");
                }
                else if (value > maxVol)
                {
                    Console.WriteLine("Too much volume");
                }
                else
                {
                    vol = value;
                }
            }
        }
    }
}
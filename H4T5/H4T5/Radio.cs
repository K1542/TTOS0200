using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4T5
{
    class Radio
    {
        private const double minHZ = 2000.0;
        private const double maxHZ = 26000.0;

        public double HZ { get; set; }
        public bool RadioOn { get; set; }
        public int Volume { get; set; }

        public Radio()
        {
         
        }
        public override string ToString()
        {
            if (RadioOn == true)
            {
                return ToString() + "Radio is on " + RadioOn + "Volume: " + Volume + "Frequency: " + HZ;
            }
            else
            {
                return ToString() + "Radio is off";
            }
        }
        
    }
}
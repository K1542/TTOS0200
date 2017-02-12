using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5T2
{
    class Song
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public override string ToString()
        {
            int mins = Length / 60;
            int secs = Length - mins * 60;
            return "Name " + Name + "Length " + mins + "," + secs;
        }
    }
}

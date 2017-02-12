using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5T2
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd1 = new CD("Nightwish", 19.99);

            // Adding with parameters, minutes and seconds.
            cd1.AddSong("Endless Forms Most Beautiful", 5);
            cd1.AddSong("Edema Ruh", 5);
            cd1.AddSong("Alpenglow", 4);
            cd1.AddSong("The Eyes of Sharbat Gula", 6);
            cd1.AddSong("The Greatest Show on Earth", 24);

            Console.WriteLine(cd1.ToString());
            Console.ReadLine();
           // Console.WriteLine(cd2.ToString());
        }
    }
}

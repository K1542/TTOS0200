using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesukone pesukone = new Pesukone();
            pesukone.Malli = "Whirlpool 3000";
            pesukone.Päällä = true;
            pesukone.Ohjelma = "Pikapesu";
            pesukone.Temp = 50;
            pesukone.Ajastus = 30;
            pesukone.Luukku = false;

            pesukone.PrintData();
            Console.ReadLine();

            pesukone.Keskeytä();
            pesukone.PrintData();
            Console.ReadLine();

            pesukone.Ohjelma2();
            pesukone.PrintData();
            Console.ReadLine();
        }
    }
}

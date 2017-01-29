using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3T2
{
    class Pesukone
    {
        public string Malli { get; set; }
        public int Temp { get; set; }
        public bool Päällä { get; set; }
        public string Ohjelma { get; set; }
        public int Ajastus { get; set; }
        public bool Luukku { get; set; }

       public void State()
        {
            Päällä = true;
            Luukku = true;
        }
        public void Keskeytä()
        {
            Päällä = false;
            Luukku = true;
        }
        public void Ohjelma2()
        {
            Ohjelma = "Tehopesu";
            Temp = 60;
            Ajastus = 0;
        }
        public void PrintData()
        {
            Console.WriteLine("Pesukone : ");
            Console.WriteLine("- Malli : " + Malli);
            Console.WriteLine("- Pesuohjelma : " + Ohjelma);
            Console.WriteLine("- Päällä : " + Päällä);
            Console.WriteLine("- Ajastin(min) : " + Ajastus);
            Console.WriteLine("- Luukku auki : " + Luukku);
        }

        // destructor
        ~Pesukone()
        {
            Console.WriteLine("Car object destroyed.");
        }
    }
}

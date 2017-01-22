using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int luku = r.Next(0, 100);
            int arvaus = 0;
            int arvaukset = 0;
            bool correct = false;

            Console.WriteLine("Arvaa luku väliltä 0-100");
            while (!correct)
            {
                Console.Write("Arvaa: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out arvaus))
                {
                    Console.WriteLine("Ei ole numero.");
                    continue;
                }

                if (arvaus < luku)
                {
                    Console.WriteLine("Luku on suurempi.");
                    arvaukset++;
                }
                else if (arvaus > luku)
                {
                    Console.WriteLine("Luku on pienempi.");
                    arvaukset++;
                }
                else
                {
                    correct = true;
                    Console.WriteLine("Arvasit oikein! Onneksi olkoon!\n");
                    arvaukset++;
                    
                }
            }
            Console.WriteLine("Arvasit {0} kertaa", arvaukset);
            Console.ReadLine();
        }
    }
}

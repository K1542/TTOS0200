using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Amp amp = new Amp();
            bool result;
            do
            {
                Console.WriteLine("Volume is set to: " + amp.volume);
                Console.WriteLine("Give a new volume value (0-100): ");
                string line = Console.ReadLine();
                int volume;
                result = int.TryParse(line, out volume);
                if (result)
                {
                    amp.volume = volume;
                }
            } while (result);
            Console.WriteLine("Volume is now: " + amp.volume);
            Console.ReadLine();
        }
    }
}
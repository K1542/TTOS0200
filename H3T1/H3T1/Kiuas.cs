using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3T1
{
    class Kiuas
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Humidity { get; set; }
        public int Temp { get; set; }
        public bool State { get; set; }
        public int DoorCount { get; set; }
        public void TempUP()
        {
            Temp += 5;
        }
        public void TempDown()
        {
            Temp -= 5;
        }

        public void HumiditydUP()
        {
            Humidity += 5;
        }
        public void HumidityDown()
        {
            Humidity -= 5;
        }
        public void PrintData()
        {
            Console.WriteLine("Kiukaan tietoja: ");
            Console.WriteLine("- Päällä: " + State);
            Console.WriteLine("- Lämpötila : " + Temp);
            Console.WriteLine("- Kosteus : " + Humidity);
        }
        ~Kiuas()
        {
            Console.WriteLine("Kiuas tuhottu");
        }
    }
}

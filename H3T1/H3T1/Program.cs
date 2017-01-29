using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas = new Kiuas();
            kiuas.State = true;
            kiuas.Temp = 80;
            kiuas.Humidity = 70;
            kiuas.PrintData();
            Console.ReadLine();
            kiuas.TempUP();
            kiuas.HumiditydUP();
            kiuas.PrintData();
            Console.ReadLine();
        }
    }
}

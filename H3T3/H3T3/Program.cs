using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Televisio tv = new Televisio();
            tv.Malli = "LG";
            tv.Väri = "Musta";
            tv.Päällä = true;
            tv.Kanava = 3;
            tv.Ohjelma = "Putous";

            tv.PrintData();
            Console.ReadLine();

            tv.KanavaYlös();
            tv.PrintData();
            Console.ReadLine();

            tv.KanavaYlös();
            tv.KanavaYlös();
            tv.PrintData();
            Console.ReadLine();
        }
    }
}

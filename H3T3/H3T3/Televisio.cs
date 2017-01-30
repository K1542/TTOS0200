using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3T3
{
    class Televisio
    {
        public string Malli { get; set; }
        public string Väri { get; set; }
        public int Kanava { get; set; }
        public bool Päällä { get; set; }
        public string Ohjelma { get; set; }
        
        public void KanavaYlös()
        {
            Kanava += 1;
            if (Kanava == 4)
            {
                Ohjelma = "Vain Elämää";
            }
            else if (Kanava == 5)
            {
                Ohjelma = "Muumit";
            }
            else if (Kanava == 6)
            {
                Ohjelma = "Simpsonit";
            }
            else
            {
                Ohjelma = "Ostos-tv";
            }
        }

        public void KanavaAlas()
        {
            Kanava -= 1;
            if (Kanava == 1)
            {
                Ohjelma = "Uutisvuoto";
            }
            else if (Kanava == 2)
            {
                Ohjelma = "Game of Thrones";
            }
            else
            {
                Ohjelma = "Ostos-tv";
            }

        }
        
        public void PrintData()
        {
            Console.WriteLine("Telkkarin tietoja : ");
            Console.WriteLine("- Malli : " + Malli);
            Console.WriteLine("- Väri : " + Väri);
            Console.WriteLine("- Virta päällä : " + Päällä);
            Console.WriteLine("- Kanava : " + Kanava);
            Console.WriteLine("- Nykyinen ohjelma : " + Ohjelma);
        }

        ~Televisio()
        {
            Console.WriteLine("Car object destroyed.");
        }
    }
}

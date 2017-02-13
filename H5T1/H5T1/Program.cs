using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persons myFriends = new Persons();
            Person friend1 = new Person { Firstname = "Heli", Lastname = "Heliseva", SocialSecurityNumber = "010190-111A" };
            Person friend2 = new Person { Firstname = "Markku", Lastname = "Mahtava", SocialSecurityNumber = "010190-121A" };
            Person friend3 = new Person { Firstname = "Tero", Lastname = "Terava", SocialSecurityNumber = "010190-113A" };

            myFriends.AddPerson(friend1);
            myFriends.AddPerson(friend2);
            myFriends.AddPerson(friend3);
            myFriends.PrintData();

            Person friend4 = myFriends.GetPerson(0);
            if (friend4 != null) Console.WriteLine(friend4);

            Person friend5 = myFriends.FindPerson("010190-113A");
            if (friend5 != null) Console.WriteLine(friend5);
            Console.ReadKey();
        }
    }
}

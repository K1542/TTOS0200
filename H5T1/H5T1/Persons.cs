using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5T1
{
    class Persons
    {
        private List<Person> persons;
        public Persons()
        {
            persons = new List<Person>();
        }
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
        public Person GetPerson(int index)
        {
            if (index < persons.Count) return persons.ElementAt(index);
            else return null;
        }

        public Person FindPerson(string socialSecurityNumber)
        {
            foreach (Person jeppe in persons)
            {
                if (socialSecurityNumber.Equals(jeppe.SocialSecurityNumber))
                    return jeppe;
            }
            return null;
        }
        public void PrintData()
        {
            foreach (Person jeppe in persons)
            {
                Console.WriteLine(jeppe.ToString());
            }
        }
    }
}

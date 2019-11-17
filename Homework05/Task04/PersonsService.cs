using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    static class PersonsService
    {
        public static List<Person> GetPersons()
        {
            var persons = new List<Person>();

            persons.Add(new Person("Finn", "Mertens", true, 14));
            persons.Add(new Person("Philip", "Fry", true, 25));
            persons.Add(new Person("Arven", "Menethil", false, 2700));
            persons.Add(new Person("Audrey", "Hepburn", false, 29));
            persons.Add(new Person("John", "Wick", true, 42));
            persons.Add(new Person("Anakin", "Skywalker", true, 29));
            persons.Add(new Person("Princess", "Bubblegum", false, 827));
            persons.Add(new Person("Svetlana", "Sokolova", false, 45));
            persons.Add(new Person("Varian", "Wrynn", true, 42));

            return persons;
        }
    }
}

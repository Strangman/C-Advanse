using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06
{
    class Program
    {
        static void Main(string[] args)
        {
            var characters = PersonsService.GetPersons();
            var personal = characters.Select(x => new { PersonDescription = $"{x.FirstName} {x.LastName} {x.Gender} {x.Age}"}) ;
            foreach (var a in personal)
                Console.WriteLine(a.PersonDescription);
            Console.ReadKey();
        }
    }
}

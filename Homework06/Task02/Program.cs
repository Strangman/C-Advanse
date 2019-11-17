using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            var characters = PersonsService.GetPersons();
            var personale = characters.Where(x => x.Age > 100).GroupBy(x => x.Gender).GroupBy(x => x.Count()).Select(x=> new {Group =x ,x.Key, Count = x.Count() });
            foreach (var a in personale)
            {
                Console.WriteLine(a.Key);
                foreach (var b in a.Group)
                {
                    Console.WriteLine(b.Key);
                    foreach (var c in b)
                        Console.WriteLine(c);
                }
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = PersonsService.GetPersons();
            var peronale = persons.Where(x => x.Age > 30).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var per in peronale)
                Console.WriteLine(per);
            Console.ReadKey();
        }
    }
}

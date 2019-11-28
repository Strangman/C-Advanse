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
            BookShelfContext dbContext = new BookShelfContext();
            var some = (from m in dbContext.Movies
                        join d in dbContext.Directors on m.DirectorId equals d.Id
                        orderby m.Id
                        select new { 
                        m.Id, m.Name, m.Genre, m.Year, d.Firstname, d.LastName,
                        });
            foreach (var a in some)
                Console.WriteLine($"Id:{a.Id}, Film:{a.Name}, Year:{a.Year}, Director:{a.Firstname} {a.LastName} ");
            Console.ReadKey();

            //Или в SQL   SELECT m.Id, m.Name, m.Genre, m.Year, d.Firstname, d.LastName
            //            FROM "Movies" m
            //            INNER JOIN "Directors" d ON d.Id = m.DirectorId

        }
    }
}

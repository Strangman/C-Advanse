using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Console.WriteLine(human.MostImportantBodeParts);
            human.Evolve();
            Console.WriteLine(human.MostImportantBodeParts);
            Console.ReadKey();
        }
    }
}

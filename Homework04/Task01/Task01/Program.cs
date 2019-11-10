using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        public delegate Q SomeDelegate<T,Q>(T a);
        static void Main(string[] args)
        {
            SomeDelegate<int, int> someDelegate = a => 5 * a;
            Console.WriteLine(someDelegate(2));
            Console.ReadKey();
        }
    }
}

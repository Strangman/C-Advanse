using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public delegate void SomeDelegate();
    class Program
    {
        public event SomeDelegate SomeEvent;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.SomeEvent += () => Console.WriteLine("Hello, Valera!!!");
            program.SomeEvent?.Invoke();
            Console.ReadKey();
        }
    }
}

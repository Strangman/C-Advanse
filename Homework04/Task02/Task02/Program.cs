using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public delegate void SomeDelegate();
    class Program
    {
        
        public event SomeDelegate SomeEvent;
        static void Main(string[] args)
        {
            Program program = new Program();
            SomeDelegate someDelegate = new SomeDelegate(program.WriteMySomething);
            program.SomeEvent += someDelegate;
            program.SomeEvent?.Invoke();
            Console.ReadKey();
        }
        public void WriteMySomething()
        {
            Console.WriteLine("Hello, Valera!!!");
        }
    }
}

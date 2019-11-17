using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05
{
    class Program
    {
        static void Main(string[] args)
        {
            Action SomeAction = new ClassForAction().SomeMethod;
            NonStaticClass.StaticMethod(SomeAction);
            Console.ReadKey();
        }
    }
}

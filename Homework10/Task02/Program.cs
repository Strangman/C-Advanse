using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCustomAttribute = new ClassForTryingAttributes().GetType().GetMethods();

            foreach (var a in firstCustomAttribute)
                foreach (var b in a.CustomAttributes)
                    Console.WriteLine(b);              //к атрибутам на приватных методах не достучатся
            Console.ReadKey();
        }
    }
}

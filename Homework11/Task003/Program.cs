using System;
using System.Threading;

namespace Task003
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart threadStart = Fibonacci;
            var someThread = new Thread(threadStart);
            int a = int.Parse(Console.ReadLine());
            someThread.Start(a);

            Console.ReadKey();
        }
        static void Fibonacci(object c)
        {
            int n = (int)c;
            int a = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }

            Console.WriteLine(a);
        }
    }
}

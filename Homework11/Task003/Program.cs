using System;
using System.Threading;

namespace Task003
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart threadStart = Fibonacci;

            var firstThread = new Thread(threadStart);
            var secondThread = new Thread(threadStart);

            firstThread.Start(2);
            secondThread.Start(5);

            for (int i = 0; i < 100; i++)
                Console.WriteLine(i);

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

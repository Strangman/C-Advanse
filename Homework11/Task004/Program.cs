using System;
using System.IO;

namespace Task004
{
    class Program
    {
        public static FileInfo file;
        static void Main(string[] args)
        {
            file = new FileInfo(@"C:\Games\Programming\C# Advanse\Homework11\Homework11\Example\Text.txt");

            Action<string> someDelegate = WriteMethode;

            someDelegate("Bora");

            Console.ReadKey();
        }
        static async void WriteMethode(string a)
        {
            using (StreamWriter write = file.CreateText())
            {
                await write.WriteAsync(a);
            }
        }
    }
}

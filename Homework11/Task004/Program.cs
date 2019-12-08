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

            using (FileStream be = new FileStream(file.FullName, FileMode.OpenOrCreate));

            Action<string> someDelegate = DoMe;

            someDelegate("Bora");
            Console.ReadKey();
        }
        static async void DoMe(string a)
        {
            using (StreamWriter write = file.CreateText())
            {
                await write.WriteAsync(a);
            }
        }
    }
}

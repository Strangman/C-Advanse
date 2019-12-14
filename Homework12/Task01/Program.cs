using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            ManClass man = new ManClass { Name = "Bob", Age = 24};

            DoMe(man).Wait();
            ShowSerialize();

            Console.ReadKey();
        }
        static async Task DoMe(ManClass a)
        {
            using (FileStream stream = new FileStream(@"C:\Games\Programming\C# Advanse\Homework12\Try\Hi.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<ManClass>(stream, a);
            }
        }
        static async void ShowSerialize()
        {
            using (FileStream stream = new FileStream(@"C:\Games\Programming\C# Advanse\Homework12\Try\Hi.json", FileMode.OpenOrCreate))
            {
                ManClass some = await JsonSerializer.DeserializeAsync<ManClass>(stream);
                Console.WriteLine(some.Age + " " + some.Name);
            }
        }
    }
}

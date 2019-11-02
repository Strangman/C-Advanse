using System;
using Collection;
using GenericClasses;
using ClassShape;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            Console.WriteLine("HelloWorld!!");
            UserCollection<int> Jack = new UserCollection<int>(); 
            Jack.Add(2);
            Jack.Add(3);
            Jack.Add(4);
            Jack.Remove(3);
            Jack.Add(5);
            Jack.Add(6);
            Jack.Add(7);
            Jack.Add(8);
            Jack.Add(9);
            Jack.Add(10);
            Jack.Remove(3);
            foreach (var a in Jack)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine(Jack.SowThis(2));
            Console.WriteLine();
            //

            // Задание 2
            Shape shape1 = new Shape("Square", 2);
            Shape shape2 = new Shape("Triangle", 5);
            Task2<int, Shape> compar = new Task2<int, Shape>();
            compar.sum = 2;
            compar.firstNumber = shape1;
            compar.secondNumber = shape2;
            Console.WriteLine(compar.Compare().name);
            //
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример добавления и удаления в ArrayList
            ArrayList firstList = new ArrayList();
            firstList.Add("Bob");
            firstList.Add(12);
            firstList.Add(0.5);
            foreach(var number in firstList)
            {
                Console.Write($"{number} ");
            }
            firstList.Remove(12);
            Console.WriteLine();
            for(int i = 0; i<firstList.Count; i++)
            {
                Console.Write(firstList[i] + " ");
            }
            Console.WriteLine();
            //

            //Пример добавления и удаления в List<T>
            List<int> secondList = new List<int>();
            secondList.Add(12);
            secondList.Add(85);
            secondList.Add(748);
            foreach(int number in secondList)
            {
                Console.Write(number + " ");
            }
            secondList.Remove(secondList[1]);
            Console.WriteLine();
            for (int i = 0; i < secondList.Count; i++)
            {
                Console.Write(secondList[i] + " ");
            }
            Console.WriteLine();
            //

            //Пример добавления и удаления в LinkedList<T>
            LinkedList<int> thirdList = new LinkedList<int>();
            thirdList.AddFirst(1);
            thirdList.AddAfter(thirdList.Last, 2);
            thirdList.AddLast(4);
            thirdList.AddBefore(thirdList.Last, 3);
            LinkedListNode<int> currentNode = thirdList.First;
            while (currentNode != null)
            {
                Console.Write(currentNode.Value + " ");
                currentNode = currentNode.Next;
            }
            thirdList.RemoveFirst();
            Console.WriteLine();
            currentNode = thirdList.First;
            while (currentNode != null)
            {
                Console.Write(currentNode.Value + " ");
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
            //

            //Пример добавления и удаления в Stack
            Stack fourthList = new Stack();
            fourthList.Push("Jack");
            fourthList.Push(12);
            fourthList.Push(15.85);
            Console.WriteLine(fourthList.Peek());
            fourthList.Pop();
            Console.WriteLine(fourthList.Peek());
            foreach(var number in fourthList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            //

            //Пример добавления и удаления в Stack<T>
            Stack<int> fifthList = new Stack<int>();
            fifthList.Push(1);
            fifthList.Push(2);
            fifthList.Push(3);
            Console.WriteLine(fifthList.Peek());
            fifthList.Pop();
            Console.WriteLine(fifthList.Peek());
            foreach (var number in fifthList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            //

            //Пример добавления и удаления в Queue
            Queue sixthList = new Queue();
            sixthList.Enqueue("Kilo");
            sixthList.Enqueue(596);
            sixthList.Enqueue(856.25);
            Console.WriteLine(sixthList.Peek());
            sixthList.Dequeue();
            Console.WriteLine(sixthList.Peek());
            foreach (var number in sixthList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            //

            //Пример добавления и удаления в Queue
            Queue<int> seventhList = new Queue<int>();
            seventhList.Enqueue(846);
            seventhList.Enqueue(596);
            seventhList.Enqueue(963);
            Console.WriteLine(seventhList.Peek());
            seventhList.Dequeue();
            Console.WriteLine(seventhList.Peek());
            foreach (var number in seventhList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            //

            //Пример добавления и удаления в HashTable
            Hashtable eighthList = new Hashtable();
            eighthList.Add(1, "Hi");
            eighthList.Add(2, "How");
            eighthList.Add(3, 5);
            foreach (var number in eighthList.Values)
            {
                Console.Write(number + " ");
            }
            eighthList.Remove(2);
            Console.WriteLine();
            foreach (var number in eighthList.Values)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            //

            //Пример добавления и удаления в HashSet<T>
            HashSet<string> ninthList = new HashSet<string>();
            ninthList.Add("Bob");
            ninthList.Add("Jack");
            ninthList.Add("Frank");
            foreach (var number in ninthList)
            {
                Console.Write(number + " ");
            }
            ninthList.Remove("Bob");
            Console.WriteLine();
            foreach (var number in ninthList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            //

            //Пример добавления и удаления в Dictionary<T,T>
            Dictionary<int, string> tenthList = new Dictionary<int, string>();
            tenthList.Add(0, "Bob");
            tenthList.Add(1, "Frank");
            tenthList.Add(2, "Jack");
            tenthList.Add(3, "Lordy");
            foreach (var number in tenthList)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
            tenthList.Remove(2);
            foreach(var number in tenthList)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
            //

            //Задание с Dictionary<IKey,IValue>
            Dictionary<IKey, IValue> homeTask2 = new Dictionary<IKey, IValue>();
            homeTask2.Add(new FirstKey(), new FirstValue());
            homeTask2.Add(new SecondKey(), new SecondValue());
            foreach (var element in homeTask2)
            {
                Console.WriteLine(element.Key + " " + element.Value);
            }
            //

            //Домашнее задание №3 с LinkedList
            LinkedList<string> homeTask3 = new LinkedList<string>();
            homeTask3.AddFirst("Bob");
            homeTask3.AddAfter(homeTask3.Last, "Jack");
            homeTask3.AddAfter(homeTask3.Last, "Jean");
            homeTask3.AddAfter(homeTask3.Last, "Brouse");
            homeTask3.AddAfter(homeTask3.Last, "Leon");
            homeTask3.AddAfter(homeTask3.Last, "Valera");
            homeTask3.AddAfter(homeTask3.Last, "Anton");
            homeTask3.AddAfter(homeTask3.Last, "Chan");
            homeTask3.AddAfter(homeTask3.Last, "Lee");
            homeTask3.AddAfter(homeTask3.Last, "Kim");
            LinkedListNode<string> homeNode = homeTask3.First;
            for (int i =0; i< homeTask3.Count; i++)
            {
                Console.WriteLine(homeNode.Value);
                homeNode = homeNode.Next;
            }
            Console.WriteLine();
            homeNode = homeTask3.First;
            for (int i = 0; i <(homeTask3.Count/2)-(homeTask3.Count % 2 == 0? 1:0); i++)
            {
                homeNode = homeNode.Next;
            }
            homeTask3.Remove(homeNode);
            homeNode = homeTask3.First;
            for (int i = 0; i < homeTask3.Count; i++)
            {
                Console.WriteLine(homeNode.Value);
                homeNode = homeNode.Next;
            }
            Console.ReadLine();
        }
    }
    interface IKey
    {
        string name { get; set; }
    }
    class FirstKey: IKey
    {
        public string name { get; set; }
        public FirstKey()
        {
            name = "Bob";
        }
        
    }
    class SecondKey : IKey
    {
        public string name { get; set; }
        public SecondKey()
        {
            name = "Jack";
        }
    }
    interface IValue
    {
        int value { get; set; }
    }
    class FirstValue: IValue
    {
        public int value { get; set; }
       public FirstValue()
        {
            value = 2;
        }
    }
    class SecondValue : IValue
    {
        public int value { get; set; }
        public SecondValue()
        {
            value = 5;
        }
    }
}

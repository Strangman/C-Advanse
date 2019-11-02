using System;

namespace Homework03
{
    class Program
    {
        delegate BigBadWolf Ba(string name);             //объявляю делегат со входным стрингом и выводом типа БольшойСтрашныйВолк
        delegate void CombineDelegate();                 //объявляю делегат без возврата для задания 2
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            // Задание 1 и 1*
            BigBadWolf bigWolf = new BigBadWolf();       // Создаю экземпляр класса БольшойСтрашныйВолк

            Ba wolf = delegate (string name)             //Задание 1 - создаю анонимный делегат со входным стрингом и выводом типа БольшойСтрашныйВолк
            {
                bigWolf.name = name;
                return bigWolf;
            };
            wolf("Jim").tryWoof();                       //Использую делегат метода Вуф в используя первый делегат
            Console.ReadKey();
            //
            Console.WriteLine();
            // Задание 2
            Console.WriteLine("Task 2");
            CombineDelegate One = delegate { Console.WriteLine("One"); };    //Содаю анонимный делегат Один
            CombineDelegate Two = delegate { Console.WriteLine("Two"); };     //Содаю анонимный делегат Два
            CombineDelegate Three = delegate { Console.WriteLine("Three"); }; //Содаю анонимный делегат Три
            CombineDelegate Four = delegate { Console.WriteLine("Four"); };    //Содаю анонимный делегат Четыри
            CombineDelegate OnePlusTwo = One + Two;                            //При добавлении 2 делегатов они выполняются поочереди
            OnePlusTwo();
            Console.WriteLine();
            CombineDelegate OnePlusTwoAndThree = OnePlusTwo + Three;           //Идентичный пример с предыдущим, но добавляется к уже скомбинированому
            OnePlusTwoAndThree();
            Console.WriteLine();
            CombineDelegate OnePlusTwoAndThreeMinusOne = OnePlusTwoAndThree - One;  //При отнимании отнимании делегат с данным именем удалается со списка воспроизведеия данного делегата
            OnePlusTwoAndThreeMinusOne();
            Console.WriteLine();
            CombineDelegate OnePlusTwoMinusFour = OnePlusTwo - Four;                 //При отнимании несуществующего делегата в данной колекции ничего не происходит
            OnePlusTwoMinusFour();
            Console.ReadKey();
        }
    }
}

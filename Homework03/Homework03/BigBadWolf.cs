using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03
{
    class BigBadWolf
    { 
        // Задание 1 и 1*
        public delegate void tryToWoof();
        public tryToWoof tryWoof = Woof;       //Задание 1* - Создаю делегат метода Вуф
        public string name { get; set; }
        public static void Woof()
        {
            Console.WriteLine("Woof Woof");
        }
    }
    
}

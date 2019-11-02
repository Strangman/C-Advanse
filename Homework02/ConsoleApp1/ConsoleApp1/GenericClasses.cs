
using ClassShape;

namespace GenericClasses
{
    class Task2<T,R> where T: struct where R: Shape //Создаю класс с двумя плэйсхолдерами и задаюи ограничения
    {
        public T sum { get; set; }   //Переменная для плэйсхолдера Т
        public R firstNumber { get; set; }
        public R secondNumber { get; set; }

        public R Compare()  //Метод с возвратом типа R
        {
            if (firstNumber.num < secondNumber.num)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
    }
}

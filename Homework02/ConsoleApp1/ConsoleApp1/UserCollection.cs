using System.Collections;
using System;
using System.Collections.Generic;

namespace Collection
{
    class UserCollection<T> : IEnumerable  //Generic колекция тип которой задается в методе Main
    {
        public List<T> numbers = new List<T>();
        public IEnumerator GetEnumerator()
        {
            return numbers.GetEnumerator();
        }
        public void Add(T a) //Реализация метода Add
        {
            numbers.Add(a);
        }
        public void Remove(T b) //Руализация метода Remove
        {
            if (numbers.Count<=5)
            {
                Console.WriteLine("You have less than 5 elements");
            }
            else
            {
                numbers.Remove(b);
            }
        }
        public T SowThis(int g) //Вывод элемента с данным индексом
        {
            return numbers[g];
        }
    }
    class Iterator<T> : IEnumerator
    {
        List<T> array;
        public Iterator(UserCollection<T> col)
        {
            array = col.numbers;
        }

        int currentPosition = -1;

        public object Current
        {
            get
            {
                return array[currentPosition];
            }
        }

        public bool MoveNext()
        {
            if (currentPosition < array.Count - 1)
            {
                currentPosition++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            currentPosition = -1;
        }
    }

}
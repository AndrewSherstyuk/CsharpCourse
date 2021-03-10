using System;

/// <summary>
/// Рекурсия
/// Простая рекурсия -  вызов методом самого себя, самовызов.
/// Рекурсивная функция представляет такую конструкцию, 
/// при которой функция вызывает саму себя.
/// При каждом вызове строится новая копия метода.
/// </summary>
namespace _024_Methods
{
    class Program
    {
        static void Main()
        {
            //Вызов рекурсивного метода
            Recursion(5);

            //Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Рекурсивный метод
        /// </summary>
        /// <param name="counter"></param>
        static void Recursion(int counter)
        {
            counter--;

            Console.WriteLine("Первая половина метода: {0}", counter);

            if (counter != 0)
            {
                Recursion(counter);
            }

            Console.WriteLine("Вторая половина метода: {0}", counter);
        }
    }
}

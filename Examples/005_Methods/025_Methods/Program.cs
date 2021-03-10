using System;

/// <summary>
/// Рекурсия 
/// Сложная рекурсия -  вызов методом себя, через другой метод.
/// </summary>
namespace _025_Methods
{
    class Program
    {
        static void Main()
        {
            Method(4);

            Console.ReadKey();
        }
        static void Method(int counter)
        {
            Console.WriteLine("Первая половина метода Method: {0}", counter);

            Recursion(counter);

            Console.WriteLine("Вторая половина метода Method: {0}", counter);
        }
        static void Recursion(int counter)
        {
            counter--;

            Console.WriteLine("Первая половина метода Recursion: {0}", counter);

            if (counter != 0)
            {
                Method(counter);
            }
            Console.WriteLine("Вторая половина метода Recursion: {0}", counter);
        }
    }
}

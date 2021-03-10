using System;

/// <summary>
/// Задача нахождения количества положительных чисел в массиве.3
/// </summary>
namespace _018_Array
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            int result = 0;
            
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    result++;
                }
            }
            
            Console.WriteLine(@"Число элементов больше нуля: {0}", result);

            //Задержка
            Console.ReadKey();
        }
    }
}

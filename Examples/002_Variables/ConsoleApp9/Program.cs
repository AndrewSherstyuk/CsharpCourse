using System;

/// <summary>
/// Извление корня из числа 
/// </summary>
namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            int variable = 64;

            //Math.Sqrt(n) - математическая функция, для извлечения квадратного кореня из числа,
            //где n - из которого необходимо извлечь корень
            double result = Math.Sqrt(variable);

            //user friendly
            Console.Write("Квадратный корень равен: ");
            //Выводим значение переменной - result, на экран.
            Console.WriteLine(result);
            
            // Задержка.
            Console.ReadKey();
        }
    }
}

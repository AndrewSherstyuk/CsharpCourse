using System;

/// <summary>
/// Дикримент — уменьшение значения переменной, операция обратная инкрименту.
/// Существуют две формы дикримент: - Постфиксная (Post-increment) и Префиксная  Pre-increment
/// </summary>
namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Постфиксный дикримент");

            int variable1 = 10;

            //Изначально вывод на экран, после уменьшаем на 1.
            Console.WriteLine(variable1--);
            Console.WriteLine(variable1);

            Console.WriteLine("Префиксный дикримент");

            int variable2 = 10;

            //Изначально уменьшаем на 1 после вывод на экран.
            Console.WriteLine(--variable2);
            Console.WriteLine(variable2);

            // Задержка.
            Console.ReadKey();
        }
    }
}

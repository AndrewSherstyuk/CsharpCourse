using System;

/// <summary>
/// Инкремент, инкрементирование (от англ. increment «увеличение») — операция увеличивающая переменную.
/// Существуют две формы инкремента: - Постфиксная (Post-increment) и Префиксная  Pre-increment
/// </summary>
namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Постфиксный инкремент");

            int variable1 = 10;

            //Изначально вывод на экран, после увеличения на 1.
            Console.WriteLine(variable1++);
            Console.WriteLine(variable1);

            Console.WriteLine("Префиксный инкремент");

            int variable2 = 10;

            //Изначально увеличения на 1 после вывод на экран.
            Console.WriteLine(++variable2);
            Console.WriteLine(variable2);

            // Задержка.
            Console.ReadKey();
        }
    }
}

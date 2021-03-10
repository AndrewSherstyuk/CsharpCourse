using System;

/// <summary>
/// Циклическая конструкция (цикл со счетчиком) - for 
/// (с досрочным выходом из цикла - break).
/// </summary>
namespace Loop
{
    class Program
    {
        static void Main()
        {
            for (int counter = 0; counter < 4; counter++)
            {
                Console.WriteLine("Counter = {0}", counter);

                //Досрочный выход из цикла - break
                break;

                Console.WriteLine("Эта строка не выполнится.");
            }

            Console.WriteLine("Строка чтобы оттенить выполнения оператора break");

            //Задержка.
            Console.ReadKey();
        }
    }
}

using System;

/// <summary>
/// Циклическая конструкция (цикл со счетчиком) - for 
/// с пропуском итерации - continue
/// Оператор continue - осуществляет переход к следующей итерации этого цикла.
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

                continue;

                Console.WriteLine("Эта строка не выполнится.");
            }

            Console.WriteLine("Строка чтобы оттенить выполнения оператора counter");

            //Задержка.
            Console.ReadKey();
        }
    }
}

using System;

/// <summary>
/// Циклическая конструкция - for (цикл со счетчиком).
/// Цикл for имеет следующее формальное определение:
/// for ([инициализация счетчика]; [условие]; [изменение счетчика])
/// {
///     действия
/// }
/// </summary>
namespace Loop
{
    class Program
    {
        static void Main()
        {
            // for ( Инициализация счетчика итераций; Условие; Изменение счетчика ) { Тело цикла }
            for (int counter = 0; counter < 4; counter++)
            {
                Console.WriteLine("Counter = {0}", counter);
            }

            //counter = 0; //  counter - недоступен за пределами цикла for.

            // Задержка.
            Console.ReadKey();
        }
    }
}

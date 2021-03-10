using System;

/// <summary>
/// Бесконечный цикл while.
/// У данного цикла будет иметься условие, 
/// однако это условие никогда не измениться и из-за этого цикл никогда не прекратит свою работу.
/// </summary>

namespace Loop
{
    class Program
    {
        static void Main()
        {
            //Счетчик для подсчета количество переходов 
            int counter = 0;

            while (true)
            {
                counter++;

                Console.WriteLine(counter);
            }

            Console.WriteLine("Этот блок кода не выполнится!");
        }
    }
}


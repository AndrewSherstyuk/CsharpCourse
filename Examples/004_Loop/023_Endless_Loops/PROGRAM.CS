using System;

/// <summary>
/// Бесконечные циклы
/// </summary>
namespace _023_Endless_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Бесконечный цикл while
            /*while (true)
            {
                Console.WriteLine("бесконечный цикл while");
            }*/

            //Бесконечный цикл do while
            /*do
            {
                Console.WriteLine("бесконечный цикл do while");

            } while (true);
            */

            //Бесконечный цикл for
            for (; ;)
            {
                Console.WriteLine("бесконечный цикл for");
            }
        }
    }
}

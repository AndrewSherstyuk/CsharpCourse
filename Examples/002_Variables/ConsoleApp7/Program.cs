using System;

/// <summary>
/// Множественное объявление переменных
/// </summary>
namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            //Стандартный вариант объявления переменных
            string str1 = "str1";
            string str2 = "str2";

            //Раскомментировать
            /*
            //Множественное объявление переменных, также возможно без инициализации
            string str1 = "str1", str2 = "str2";
            */
            /*
            //Множественное объявление переменных, без инициализации
            string str1, str2;
            */

            Console.WriteLine(str1);
            Console.WriteLine(str2);

            // Задержка.
            Console.ReadKey();
        }
    }
}

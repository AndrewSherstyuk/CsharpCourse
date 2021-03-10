using System;

/// <summary>
/// dynamic
/// dynamic, может получить какое угодно начальное значение, и на протяжении времени его существования 
/// это значение может быть заменено новым (и возможно, не связанным с первоначальным).
/// </summary>
namespace _019_Dynamic
{
    class Program
    {
        static void Main()
        {
            dynamic @string = "Привет мир!";

            //Выводим значение переменной - @string, на экран.
            Console.WriteLine(@string);

            //Выводим информацию о типе переменной @string, НЕ работает INTELLISENSE!
            Console.WriteLine(@string.GetType());

            //Оттеняем вывод на экран
            Console.WriteLine(new string('*', 30));
            /*****************************************************************************/

            // Еще одна неявно типизированная локальная переменная переменная.
            dynamic @int = 15;

            //Выводим значение переменной - @int, на экран.
            Console.WriteLine(15);

            //Выводим информацию о типе переменной @string
            Console.WriteLine(@int.GetType());

            //Оттеняем вывод на экран
            Console.WriteLine(new string('*', 30));
            /*****************************************************************************/

            //1) dynamic допускают множественного объявления.
            dynamic str1 = "str1", str2 = "str2", str3 = "str1";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);

            //2) Неявно типизированные локальные переменные может быть не инициализирована 
            //(в момент создания).
            dynamic a;
            
            // Задержка.
            Console.ReadKey();
        }
    }
}

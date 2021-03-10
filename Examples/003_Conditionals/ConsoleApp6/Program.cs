using System;

/// <summary>
/// Тернарная операция.
/// Синтаксис:
/// [первый операнд - условие] ? [второй операнд] : [третий операнд].
/// Выражения [?] и [:]  - всегда должны быть одного типа!!!.
/// </summary>
namespace Conditional_Lessons
{
    class Program
    {
        static void Main()
        {
            //Создание переменной x типа int;
            int x = 10;

            //Создание переменной y типа double;
            double y = 20;

            //Создание переменной result типа int, для хранения результат операции;
            int result;

            //Приводим переменную типа y типа double к int
            result = x > y ? x : (int)y;

            //или 2-й варинт
            result = (int)(x > y ? x : y);

            Console.WriteLine(result);
            
            /************************************************************************/
            /*************************ПРИМЕР 2***************************************/
            /************************************************************************/

            string @string = "string";
            bool @bool = false;

            //Вопрос какого типа должен быть результат тернарной операции для переменных @string и @bool.
            //например string (@bool.ToString() - убрать получения строкового представления данного объекта)

            string secondResult = true ? @string : @bool.ToString();

            Console.WriteLine(secondResult);

            //Задержка
            Console.ReadKey();
        }
    }
}

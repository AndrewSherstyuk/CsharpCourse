﻿using System;

/// <summary>
/// В цикле do while сначала выполняется код цикла, а потом происходит проверка условия в инструкции while. 
/// И пока это условие истинно, цикл повторяется. 
/// do
/// {
///     блок команд
/// }
/// while (логическое_выражение, условие)
/// </summary>
namespace Loop
{
    class Program
    {
        static void Main()
        {
            //Счетчик c заданным количество итераций
            int counter = -10;
            Console.WriteLine("Всего будет выполнено {0} итераций.", counter);

            do
            {
                //Вывод на консоль значение счетчика итераций
                Console.WriteLine(string.Format(@"Итерация номер {0}", counter));

                //С помощью декремента уменьшить счетчик на 1
                counter--;

            //Если стечик больше 0, тогда повторяем тело цикла while
            } while (counter > 0);

            //Задержка
            Console.ReadKey();
        }
    }
}

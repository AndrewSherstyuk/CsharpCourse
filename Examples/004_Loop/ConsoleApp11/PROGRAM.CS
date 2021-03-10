using System;

/// <summary>
/// while (логическое_выражение, условие)
/// {
///     блок команд
/// }
/// </summary>
namespace Loop
{
    class Program
    {
        static void Main()
        {
            //Счетчик c заданным количество итераций
            int counter = 5;
            Console.WriteLine("Всего будет выполнено {0} итераций.", counter);

            //Если стечик больше 0, тогда входим в тело цикла while
            while (counter > 0)
            {
                //Вывод на консоль значение счетчика итераций
                Console.WriteLine(string.Concat("Итерация номер ", counter));

                //С помощью декремента уменьшить счетчик на 1
                counter--;
            }

            //Задержка
            Console.ReadKey();
        }
    }
}

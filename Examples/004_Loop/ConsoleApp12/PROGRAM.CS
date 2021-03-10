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
            //Счетчик для подсчета количество переходов 
            int counter = 0;

            //Если стечик меньше 5, тогда входим в тело цикла while
            while (counter < 5)
            {
                //С помощью инкремента увеличить счетчик на 1
                counter++;

                //Вывод на консоль значение счетчика итераций
                Console.WriteLine(string.Format(@"Итерация номер {0}", counter));
            }

            Console.WriteLine("Всего выполнено {0} итераций.", counter);

            //Задержка
            Console.ReadKey();
        }
    }
}

using System;

/// <summary>
/// Циклическая конструкция - while. (с досрочным выходом из цикла - break)
/// оператор break - при его использовании мы можем выйти из цикла, не дожидаясь его завершени.
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

                //оператор break
                break;

                Console.WriteLine("Этот блок кода не выполнится!");
            }

            Console.WriteLine("Всего выполнено {0} итераций.", counter);

            //Задержка
            Console.ReadKey();
        }
    }
}


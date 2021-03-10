using System;

/// <summary>
/// Оператор безусловного перехода - goto.
/// В связке с условными конструкциями
/// </summary>

namespace Loop
{
    class Program
    {
        static void Main()
        {
            //Принимаем ввод от пользователя
            string value = Console.ReadLine();

            //Если введенная фраза равна true
            if (value == "true")
            {
                //Переход к метке myLabel 
                goto myLabel;
            }

            Console.WriteLine("первая строка");

            myLabel:
            Console.WriteLine("вторая строка");

            //Задержка
            Console.ReadKey();
        }
    }
}

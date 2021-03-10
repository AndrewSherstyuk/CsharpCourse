using System;

/// <summary>
/// Угадай загадку.
/// Используя цикл while, а также операторы break и continue написать программу с помощью которой 
/// можно отгадать следующую загадку:
/// На раскрашенных страницах. Много праздников хранится.
/// Ответ "Календарь"
/// </summary>
namespace Loop
{
    class Program
    {
        static void Main()
        {
            const int maxAttempt = 5; // Допустимое количество попыток.
            int attempt = 0;          // Счетчик попыток.

            while (attempt < maxAttempt)
            {
                attempt++;
                string key = Console.ReadLine();

                if (key == "exit")
                {
                    Console.WriteLine("Жаль что вы нас покидаете:(");
                    break;
                }

                if (key != "календарь")
                {
                    continue;
                }

                Console.WriteLine("Поздравляем, Вы угадали с {0} попытки!", attempt);
            }

            Console.WriteLine("Завершен!");

            Console.ReadLine();
        }

        
    }
}


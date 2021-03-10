using System;

/// <summary>
/// При выводе строк в консоли с помощью метода Console.WriteLine мы 
/// можем применять форматирование вместо конкатенации:
/// </summary>
namespace _016_String_Format
{
    class Program
    {
        static void Main()
        {
            //1-е слово для конкатенации
            string word1 = "Привет";
            //2-е слово для конкатенации
            string word2 = "мир!";

            Console.WriteLine(string.Format(@"{0} {1}", word1, word2));

            Console.WriteLine(new string('*', 30));

            int x = 10;
            int y = 20;
            int z = x + y;

            Console.WriteLine(string.Format(@"Сумма чисел {0} и {1} равна {2};", x, y, z));

            // Задержка.
            Console.ReadKey();
        }
    }
}

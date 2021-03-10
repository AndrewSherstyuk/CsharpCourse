using System;

/// <summary>
/// Конкатенация
/// Конкатена́ция (лат. concatenatio «присоединение цепями; сцепле́ние») — операция 
/// склеивания объектов линейной структуры, обычно строк. Например, конкатенация 
/// слов «микро» и «мир» даст слово «микромир».
/// </summary>
namespace _015_Concatenation
{
    class Program
    {
        static void Main()
        {
            //1-е слово для конкатенации
            string word1 = "Привет ";
            //2-е слово для конкатенации
            string word2 = "мир!";

            //Вариант 1
            //Конкатенация
            string сoncatenation = word1 + word2;
            Console.WriteLine(сoncatenation);

            Console.WriteLine(new string('+', 30));
            //Вариант 2
            Console.WriteLine("Привет " + "мир!");

            Console.WriteLine(new string('*', 30));
            //Вариант 3
            //На объекте string вызываем метод Concat, который в качестве 
            //аргументов принимает "слова" для конкатенации
            Console.WriteLine(string.Concat("Привет ", "мир"));
            
            // Задержка.
            Console.ReadKey();
        }
    }
}

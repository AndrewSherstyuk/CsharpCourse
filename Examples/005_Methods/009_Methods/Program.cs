using System;

/// <summary>
///  Использование сторожевого оператора, для защиты номинального варианта.
/// </summary>
namespace _009_Methods
{
    class Program
    {
        static void Main()
        {
            string word = Function("глупец");

            Console.WriteLine(word);

            // Задержка.
            Console.ReadKey();
        }

        static string Function(string name)
        {
            // Выполняем проверку. При обнаружении ошибок завершаем работу.
            // Сторожевой оператор.
            if (name == "глупец")   
            {
                return "Вы использовали недопустимое слово.";
            }

            // Код номинального варианта.
            string sentence = "Hello " + name + "!";

            return sentence;
        }
    }
}

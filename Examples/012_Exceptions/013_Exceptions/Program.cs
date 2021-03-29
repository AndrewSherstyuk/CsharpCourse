using System;

/// <summary>
/// Обработка исключений
/// Язык C# предоставляет разработчикам возможности для обработки ошыбок которые 
/// возникают во время выполнения, для этого в C# предназначена 
/// конструкция try...catch...finally.
/// </summary>
namespace _013_Exceptions
{
    class Program
    {
        static void Main()
        {
            int x = 10;
            int y = 20;

            //x = x / (y - 20);
            try
            {
                //Попытка деления на 0
                x = x / (y - 20);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Поп");
                Console.WriteLine("Обработка исключения");
                Console.WriteLine(exception.Message);
                exception.HelpLink = "https://docs.google.com/spreadsheets/d/1DHUiWWdFf0xkmmlFuW6OngXwqz3w8_SdDjpwmJGqwu0/edit#gid=1747445904";
                Console.WriteLine(exception.HelpLink);
            }

            Console.WriteLine("to do");

            //Задержка
            Console.ReadKey();
        }
    }
}

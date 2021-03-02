using System;

/// <summary>
/// Конструкция switch/case. Проваливание.
/// Использую конструкцию switch/case, запросить у пользователя номер месяца года и в зависимости от выбранного месяца
/// определить пору года.
/// </summary>
namespace Conditional_Lessons
{
    class Program
    {
        static void Main()
        {
            //Предложение пользователю номе месяца.
            Console.WriteLine("Ввидите номер месяца");

            //Принимаем ввод от пользователя.
            string month = Console.ReadLine();

            switch (month)
            {
                //Для пустых операторов case разрешено "проваливание" от одного оператора к другому. 
                case "1":
                case "2":
                case "12":
                    Console.WriteLine("{0} месяц года это Зима!", month);
                    break;
                case "3":
                case "4":
                case "5":
                    Console.WriteLine("{0} месяц года это Весна!", month);
                    break;
                case "6":
                case "7":
                case "8":
                    Console.WriteLine("{0} месяц года это Лето", month);
                    break;
                case "9":
                case "10":
                case "11":
                    Console.WriteLine("{0} месяц года это Осень", month);
                    break;
                default:
                    Console.WriteLine();
                    break;
            }

            //Задержка
            Console.ReadKey();
        }
    }
}

using System;

namespace _017_Formatting_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Формат процентов
            //Описатель "P" задает отображение процентов.
            //Используемый с ним числовой спецификатор указывает, 
            //сколько знаков будет после запятой:
            decimal number1 = 0.15345m;
            Console.WriteLine("{0:P1}", number1);// 15.3%

            Console.WriteLine(new string('*', 30));

            //Вывод в десятичном формате.
            //К-ло знаков после зааятой можно менять (F2), (F3)
            int number2 = 10;
            Console.WriteLine("{0:F2}", number2);
            Console.WriteLine("{0:F3}", number2);

            Console.WriteLine(new string('*', 30));
            
            int variable = 25;

            // Стандартное числовое форматироваание.
            Console.WriteLine("{0:N}", variable);
            // Вывод в шеснадцатиричном формате.
            Console.WriteLine("{0:X}", variable);
            // Вывод в десятичном формате.
            Console.WriteLine("{0:D}", variable);
            // Вывод в экспоненциальном формате.
            Console.WriteLine("{0:E}", variable);
            // Вывод в общем формате.
            Console.WriteLine("{0:G}", variable);      

            // Задержка.
            Console.ReadKey();
        }
    }
}

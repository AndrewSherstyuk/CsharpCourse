using System;

/// <summary>
/// Получение типа переменной.
/// Чтобы управлять типом и получать всю информацию о нем, нам надо сперва получить данный тип. 
/// Это можно сделать с помощью метод Type.GetType(), где Type - имя перпенной, 
/// тип которой нам необходимо узнать
/// </summary>
namespace _018_Get_Type
{
    class Program
    {
        static void Main()
        {
            //Переменная и именем @string, типа string
            string @string = "string";
            //Переменная и именем @int, типа int
            int @int = 10;
            //Переменная и именем @double, типа double
            double @double = 15;

            //Вывод информации о типе переменной string
            Console.WriteLine(@string.GetType());
            //Вывод информации о типе переменной int
            Console.WriteLine(@int.GetType());
            //Вывод информации о типе переменной double
            Console.WriteLine(@double.GetType());

            // Задержка.
            Console.ReadKey();
        }
    }
}

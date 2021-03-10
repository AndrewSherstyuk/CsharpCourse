using System;

/// <summary>
///  unchecked
///  С помошью оператора unchecked происходит ЗАПРЕТ проверка переполнения
/// </summary>
namespace _022_Unchecked
{
    class Program
    {
        static void Main()
        {
            byte a = 255;
            byte b = 10;
            byte c;

            //c = (byte)(a + b);
            //Console.WriteLine(c);

            //Ошибка при компиляции приложения 
            //Arithmetic operation resulted in an overflow.
            //Раскоментировать
            unchecked
            {
                c = (byte)(a + b);
            }

            Console.WriteLine(c);

            // Задержка.
            Console.ReadKey();
        }
    }
}

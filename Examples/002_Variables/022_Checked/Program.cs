using System;

/// <summary>
///  checked
///  С помошью оператора checked происходит проверка переполнения
/// </summary>
namespace _022_Checked
{
    class Program
    {
        static void Main()
        {
            byte a = 255;
            byte b = 10;
            byte c;

            //c = (byte)(a + b);

            //Ошибка при компиляции приложения 
            //Arithmetic operation resulted in an overflow.
            //Раскоментировать
            checked
            {
                c = (byte)(a + b);
            }

            Console.WriteLine(c);

            // Задержка.
            Console.ReadKey();
        }
    }
}

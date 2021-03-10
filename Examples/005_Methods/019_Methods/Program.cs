using System;

/// <summary>
/// перегрузка методов (Методы с опциональными параметрами)
/// </summary>
namespace _019_Methods
{
    class Program
    {
        static void Main()
        {
            Method();
            Method(1);
            Method(1, "Method3");
            Method(1, "Method4", 3.5);

            //Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// 1-я перегрузка метода
        /// </summary>
        static void Method()
        {
            //Вызов метода Method с 3-мя параметрами
            Method(1, "argument", 1.5);
        }

        /// <summary>
        /// 2-я перегрузка метода
        /// </summary>
        static void Method(int argument1)
        {
            //Вызов метода Method с 3-мя параметрами
            Method(argument1, "argument", 1.5);
        }

        /// <summary>
        /// 3-я перегрузка метода
        /// </summary>
        static void Method(int argument1, string argument2)
        {
            //Вызов метода Method с 3-мя параметрами
            Method(argument1, argument2, 1.5);
        }

        /// <summary>
        /// 4-я перегрузка метода
        /// </summary>
        static void Method(int argument1, string argument2, double argument3)
        {
            //Вызов метода Method с 3-мя параметрами
            Console.WriteLine(@"{0} - {1} - {2}", argument1, argument2, argument3);
        }
    }
}

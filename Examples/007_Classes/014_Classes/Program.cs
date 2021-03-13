using System;

/// <summary>
/// Класс в качестве возвращаемого значения метода
/// </summary>
namespace _014_Classes
{
    class Program
    {
        static void Main()
        {
            string str = GetRectangle(10, 20);

            //Создаем экземпляр класса Rectangle с именем rectangle.
            Rectangle rectangle = GetRectangle(10,20);

            //Вывод информации 
            Console.WriteLine("Площадь прямоугольника {0}", rectangle.Square);
            Console.WriteLine("Периметр прямоугольника {0}", rectangle.Perimeter );

            //Задержка.
            Console.ReadKey();
        }

        /// <summary>
        /// Метод который в качестве возращаемого значения, возвращает Rectangle
        /// </summary>
        /// <param name="a">1-я сторона прямоугольника</param>
        /// <param name="b">2-я сторона прямоугольника</param>
        /// <returns>экземпляр класса Rectangle</returns>
        static Rectangle GetRectangle(int a, int b)
        {
            //Создаем экземпляр класса Rectangle с именем rectangle.
            Rectangle rectangle = new Rectangle();

            //Присваем полям экземпляр значения
            rectangle.Square = a * b;
            rectangle.Perimeter = 2 * (a + b);

            //Возвращаем экземпляр класса Rectangle
            return rectangle;
        }
    }


    /// <summary>
    /// Класс для описания для Прямоугольника
    /// </summary>
    class Rectangle
    {
        /// <summary>
        /// Площадь прямоугольника
        /// </summary>
        public decimal Square { get; set; }


        /// <summary>
        /// Периметр прямоугольника
        /// </summary>
        public decimal Perimeter { get; set; }
    }
}

using System;

/// <summary>
/// Класс в качестве аргумента метода
/// </summary>
namespace _013_Classes
{
    class Program
    {
        static void Main()
        {
            //Создаем экземпляр класса Rectangle с именем rectangle.
            Rectangle rectangle = new Rectangle();
            rectangle.FirstSide = 10;
            rectangle.SecondSide = 10;

            //Переменная для хранения площади прямоугольника
            int square;
            //Присваиваем возвращаемое значение метода переменной square
            square = GetRectangleSquare(rectangle);

            Console.WriteLine(string.Format(@"Площадь прямоугольника = {0} * {1} = {2}",
                rectangle.FirstSide, rectangle.SecondSide, square));

            //Задержка.
            Console.ReadKey();
        }

        /// <summary>
        /// Метод который в качестве аргумена принимает 
        /// класс RECTANGLE - Класс для описания для Прямоугольника
        /// </summary>
        /// <param name="rectangle">RECTANGLE - Класс для описания для Прямоугольника</param>
        /// <returns>Площадь прямоугольника</returns>
        static int GetRectangleSquare(Rectangle rectangle)
        {
            int Square = rectangle.FirstSide * rectangle.SecondSide;

            return Square;
        }
    }

    /// <summary>
    /// Класс для описания для Прямоугольника
    /// </summary>
    class Rectangle
    {
        /// <summary>
        /// Первая сторона
        /// </summary>
        public int FirstSide { get; set; }

        /// <summary>
        /// Вторая сторона
        /// </summary>
        public int SecondSide { get; set; }
    }
}

using System;

/// <summary>
/// Конструктор
/// Кроме обычных методов в классах используются также и специальные методы, 
/// которые называются конструкторами. Конструкторы вызываются при создании нового 
/// объекта данного класса. Конструкторы выполняют инициализацию объекта.
/// Если в классе не определено ни одного конструктора, то для этого класса автоматически 
/// создается конструктор по умолчанию. Такой конструктор 
/// не имеет параметров и не имеет тела.
/// </summary>
namespace _007_Classes
{
    class Program
    {
        static void Main()
        {
            //Применяем конструктор по умолчанию.
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("1- я строна = {0}, 2- я строна = {1}", 
                rectangle.FirstSide, rectangle.SecondSide);

            //Применяем пользовательский конструктор с параметрами.
            Rectangle rectangle1 = new Rectangle(10, 20);
            Console.WriteLine("1- я строна = {0}, 2- я строна = {1}",
                rectangle1.FirstSide, rectangle1.SecondSide);


            Console.ReadKey();
        }
    }

    /// <summary>
    /// Прямоугольник
    /// </summary>
    class Rectangle
    {
        /// <summary>
        /// Первая сторона прямоугольника
        /// </summary>
        private int firstSide;

        /// <summary>
        /// Вторая сторона прямоугольника
        /// </summary>
        private int secondSide;

        /// <summary>
        /// Свойство только для чтения для 1-й стороны
        /// </summary>
        public int FirstSide
        {
            get 
            {
                return firstSide;
            }
        }

        /// <summary>
        /// Свойство только для чтения для 2-й стороны
        /// </summary>
        public int SecondSide
        {
            get
            {
                return secondSide;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// Основная задача - инициализация полей значениями по умолчанию.
        /// </summary>
        public Rectangle()
        {
            //Оттеняем вызов конструктора по умолчанию
            Console.WriteLine("Rectangle() - конструктор по умолчанию");
        }

        /// <summary>
        /// Пользовательский конструктор
        /// Основная задача - инициализация полей значениями заданными пользователем.
        /// </summary>
        /// <param name="a">1-я строна прямоугольника</param>
        /// <param name="b">2-я строна прямоугольника</param>
        public Rectangle(int a, int b)
        {
            //Оттеняем вызов пользовательского конструктора
            Console.WriteLine("Rectangle(int a, int b) - пользовательский конструктор");

            firstSide = a;
            secondSide = b;
        }
    }
}

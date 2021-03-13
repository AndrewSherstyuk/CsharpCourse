using System;

/// <summary>
/// Конструктор
/// Tсли в классе определены пользовательские конструкторы, то при создании объекта 
/// необходимо использовать один из этих конструкторов, конструктор 
/// по умолчанию при (создании пользовательских конструкторов) этом не сохраняется.
/// </summary>
namespace _008_Classes
{
    class Program
    {
        static void Main()
        {
            //Раскоментировать--ошибка уровня компиляции
           
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

        /*
        /// <summary>
        /// Конструктор по умолчанию
        /// Основная задача - инициализация полей значениями по умолчанию.
        /// </summary>
        public Rectangle()
        {
            //Оттеняем вызов конструктора по умолчанию
            Console.WriteLine("Rectangle() - конструктор по умолчанию");
        }
        */

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

            this.firstSide = a;
            this.secondSide = b;
        }

        public Rectangle()
        {

        }
    }
}

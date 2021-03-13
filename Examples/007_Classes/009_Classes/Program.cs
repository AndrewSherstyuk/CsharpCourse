using System;

/// <summary>
/// Конструктор
/// Конструктор может вызывать в том же самом объекте другой конструктор 
/// с помощью ключевого слова this.
/// </summary>
namespace _009_Classes
{
    class Program
    {
        static void Main()
        {
            //Создаем экземпляр класса Rectangle с именем rectangle, 
            //используем конструктор с 2-мя параметрыми
            Rectangle rectangle = new Rectangle(10, 20);

            Console.WriteLine("1- я строна = {0}, 2- я строна = {1}",
               rectangle.FirstSide, rectangle.SecondSide);

            Console.WriteLine(new string('*',30));

            //Создаем экземпляр класса Rectangle с именем rectangle1.
            //используем конструктор с 2-мя параметрыми
            Rectangle rectangle1 = new Rectangle(10, 20, 22);
            
            Console.WriteLine("1- я строна = {0}, 2- я строна = {1}",
               rectangle1.FirstSide, rectangle1.SecondSide);

            //Задержка
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
        /// Диагональ сторона прямоугольника
        /// </summary>
        private int diagonal;

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
        /// Свойство только для чтения для дигонали
        /// </summary>
        public int Diagonal
        {
            get
            {
                return diagonal;
            }
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
            Console.WriteLine("Rectangle(int a, int b) - пользовательский конструктор с 2-мя параметрами");

            this.firstSide = a;
            this.secondSide = b;
        }

        // Использование ключевого слова this в конструкторе приводит к вызову 
        //конструктора с двумя параметрами
        public Rectangle(int a, int b, int diagonal) 
            :this(a, b)
        {
            Console.WriteLine("Rectangle(int a, int b) - пользовательский конструктор с 3-мя параметрами");
            this.diagonal = diagonal;
        }

        public Rectangle(int a, int b, int diagonal, int Area)
        : this(a, b, diagonal)
        {
            Console.WriteLine("Rectangle(int a, int b) - пользовательский конструктор с 3-мя параметрами");
            
        }
    }
}
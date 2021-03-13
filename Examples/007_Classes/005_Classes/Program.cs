using System;

/// <summary>
/// Классы
/// Использование свойств с одним методом доступа
/// (Свойство только для записи, или Свойство только для чтения)
/// </summary>
namespace _005_Classes
{
    class Program
    {
        static void Main()
        {
            //Создаем экземпляр класса MyClass с именем instance.
            MyFirstСlass myFirstСlass = new MyFirstСlass();

            //Свойство только для чтения
            Console.WriteLine(myFirstСlass.Pi);
            //При попыпитке записать значение, ошибка уровня компиляции
            //myFirstСlass.Pi = 3.14;

            //Свойство только для записи
            myFirstСlass.G = 9.8;
            //При попыпитке записать значение, ошибка уровня компиляции
            //Console.WriteLine(myFirstСlass.G);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    ///  Мой первый класс
    /// </summary>
    class MyFirstСlass
    {
        /// <summary>
        /// Закритое поле в классе
        /// </summary>
        private double pi = 3.14;

        /// <summary>
        /// Закритое поле в классе
        /// </summary>
        private double g;

        /// <summary>
        /// Свойство только для чтения
        /// </summary>
        public double Pi
        {
            get 
            {
                return pi;
            }
        }

        /// <summary>
        /// Свойство только для записи
        /// </summary>
        public double G
        {
            set
            {
                g = value;
            }
        }

    }
}

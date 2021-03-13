using System;

/// <summary>
/// Классы
/// Класс представляет новый тип, который определяется пользователем. 
/// Класс определяется с помощью ключевого слова сlass:
/// </summary>
namespace _001_Classes
{
    class Program
    {
        static void Main()
        {
            //Создаем экземпляр класса MyClass с именем instance.
            MyFirstСlass instanse = new MyFirstСlass();

            //Полю field, экземпляра instance, присваиваем значение
            instanse.field = "Hello from method in class";

            //Выводим на экран значение поля field экземпляра instance.
            Console.WriteLine(instanse.field);

            //Вызов метода с именем Method на экземпляре instance.
            instanse.Method();

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Мой первый класс
    /// </summary>
    class MyFirstСlass
    {
        /// <summary>
        /// Поле в классе
        /// </summary>
        public string field;

        /// <summary>
        /// Метод для вывода значения переменной field
        /// </summary>
        public void Method()
        {
            Console.WriteLine(field);
        }
    }
}

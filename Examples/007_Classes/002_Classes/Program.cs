using System;

/// <summary>
/// Классы
/// Закритое (private) поле. 
/// </summary>
namespace _002_Classes
{
    class Program
    {
        static void Main()
        {
            //Создаем экземпляр класса MyClass с именем instance.
            MyFirstСlass instanse = new MyFirstСlass();

            //field - private - невозможно установить значение, 
            //не доступен из за уровня защиты
            //instanse.field = "Hello";

            //С помощью метода мутатор устанавливаем значение private поля field
            instanse.SetField("Hello");

            //С помощью метода аксессора получаем значение private поля field
            string @string =  instanse.GetField();

            //Вывод значения переменной @string
            Console.WriteLine(@string);

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
        /// Закритое поле в классе
        /// </summary>
        private string field = string.Empty;

        /// <summary>
        /// Метод-мутатор (setter), для установки
        /// значения
        /// </summary>
        /// <param name="value"></param>
        public void SetField(string value) 
        {
            field = value;
        }

        /// <summary>
        /// Метод аксессор (getter), для получения
        /// значения
        /// </summary>
        /// <returns></returns>
        public string GetField()          
        {
            return field;
        }

    }
}

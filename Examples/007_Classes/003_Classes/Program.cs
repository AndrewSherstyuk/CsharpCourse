using System;

/// <summary>
/// Классы
/// Использование свойств, для доступа к закрытым полям.
/// Кроме обычных методов в языке C# предусмотрены специальные методы доступа, 
/// которые называют свойства. Они обеспечивают простой доступ к полям 
/// классов, для того чтоб узнать их значение или выполнить их установку.
/// </summary>
namespace _003_Classes
{
    class Program
    {
        static void Main()
        {
            //Создаем экземпляр класса MyFirstСlass с именем instance.
            MyFirstСlass a = new MyFirstСlass();

            //С помощью метода мутатор устанавливаем значение private поля field
            a.Field = "Hello world!";

            //С помощью метода аксессора получаем значение private поля field
            string @string = a.Field;

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
        /// Свойство Field для работы с полем field
        /// значения
        /// </summary>
        public string Field
        {
            //мутатор (setter), для установки значения
            set  // void SetField(string value)
            {
                field = value;
            }
            //аксессор (getter), для получения значения
            get  // string GetField()
            {
                return field;
            }
        }
    }
}

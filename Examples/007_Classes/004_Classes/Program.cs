using System;

/// <summary>
/// Классы
/// Использование свойств с условными конструкциями
/// </summary>
namespace _004_Classes
{
    class Program
    {
        static void Main()
        {
            //Создаем экземпляр класса MyClass с именем instance.
            MyFirstСlass instanse = new MyFirstСlass();

            instanse.Field = "Дурачок";
            Console.WriteLine(instanse.Field);

            //Оттеняем присвоения полю field другого значения
            Console.WriteLine(new string('*', 30));

            instanse.Field = "some value";
            Console.WriteLine(instanse.Field);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    ///  Мой первый класс
    /// </summary>
    class MyFirstСlass
    {
        public string someField;

        /// <summary>
        /// Закритое поле в классе
        /// </summary>
        private string field = string.Empty;

        // <summary>
        /// Свойство Field для работы с полем field
        /// значения
        /// </summary>
        public string Field
        {
            //мутатор (setter), для установки значения
            set
            {
                //Можем устанавливать проверки, взависимости от результата 
                //присваивать или нет значение поля Field
                if (value == "Дурачок")
                {
                    Console.WriteLine("Вы ввели недопустию фразу");
                }
                else
                {
                    field = value;
                }
                
            }
            //аксессор (getter), для получения значения
            get
            {
                //Можем выводить различные значения в зависимости от опрделенных
                //условий
                if (string.IsNullOrEmpty(field))
                {
                    return "В поле field нету данных:(";
                }
                else
                {
                    return field;
                }
            }
        }
    }
}

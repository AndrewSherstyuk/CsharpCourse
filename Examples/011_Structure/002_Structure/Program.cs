using System;

/// <summary>
/// Структура - конструктор
/// Если в структуре имеются члены, которые обращаются к полю 
/// и нет пользовательского конструктора,  то требуется при 
/// создании экземпляра вызывать конструктор по умолчанию.
/// </summary>
namespace _002_Structure
{
    class Program
    {
        static void Main()
        {
            // Создание экземпляра структыры с вызовом 
            // конструктора по умолчанию.
            MyStruct myStruct = new MyStruct();
            myStruct.Display();

            Console.WriteLine(myStruct.Field);

            myStruct.Field = null;
            myStruct.Display();

            Console.WriteLine(myStruct.Field);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Структура MyStruct
    /// </summary>
    struct MyStruct
    {
        private string field;

        private string field2;

        private int field3;

        public MyStruct(string field)
        {
            this.field = field;
            this.field2 = field;
            this.field3 = 0;

        }

        public string Field
        {
            get { return field; }
            set { field = value; }
        }

        public void Display()
        {
            Console.WriteLine(field);
        }
    }
}

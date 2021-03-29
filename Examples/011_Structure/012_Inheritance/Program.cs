using System;

/// <summary>
/// Структуры. Наследование.
/// Все структуры неявно наследуются 
/// от абстрактного класса - ValueType
/// </summary>
namespace _012_Inheritance
{
    class Program
    {
        static void Main()
        {
            // Создание экземпляра структурного типа
            MyStruct myStruct = new MyStruct();

            //Приводим экземпляра структурного к абстактному 
            //классу  ValueType
            ValueType valueType = myStruct as ValueType;

            //Выводим Hash Code экземпляров
            Console.WriteLine(myStruct.GetHashCode());
            Console.WriteLine(valueType.GetHashCode());

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Структура MyStruct
    /// </summary>
    struct MyStruct //: ValueType
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }
}

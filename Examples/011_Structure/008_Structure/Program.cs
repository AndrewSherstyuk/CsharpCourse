using System;

/// <summary>
/// Структура - автоматически реализуемые свойства;
///  В структурах можно создавать автоматически реализуемые 
///  свойства, при этом требуется использовать конструктор 
///  при построении экземпляра.
/// </summary>
namespace _008_Structure
{
    class Program
    {
        static void Main()
        {
            // Создание экземпляра структуры,
            // без вызова конструктора.
            MyStruct myStruct;

            //Попытка обращения к автосвойству, ошыбка уровня 
            //компиляции
            //myStruct.MyProperty = "";

            //используем конструктор
            myStruct = new MyStruct();

            Console.WriteLine(myStruct.MyProperty);

            //Можем рабоать с автосвойством
            myStruct.MyProperty = "Hello from field structure";

            Console.WriteLine(myStruct.MyProperty);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Структура MyStruct
    /// </summary>
    struct MyStruct
    {
        /// <summary>
        /// Автоматически реализуемое свойство в структуре
        /// </summary>
        public string MyProperty { get; set; }
    }
}

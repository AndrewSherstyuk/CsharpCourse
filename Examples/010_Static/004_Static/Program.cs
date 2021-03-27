using System;

/// <summary>
/// Статический конструктор
/// Статические конструкторы обладают следующими свойствами:
/// 1. Статический конструктор не имеет модификаторов доступа и не принимает параметров.
/// 2. Статический конструктор вызывается автоматически для инициализации класса перед созданием первого экземпляра
///   или ссылкой на какие-либо статические члены. 
/// 3. Статический конструктор нельзя вызывать напрямую.
/// 4. Пользователь не управляет тем, когда статический конструктор выполняется в программе.
/// 5. Типичным использованием статических конструкторов является случай, когда класс использует файл журнала и
/// конструктор применяется для добавления записей в этот файл.
/// </summary>
namespace _004_Static
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            
            //Console.WriteLine(MyClass.ReadonlyField);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    ///  Класс MyClass
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// Статическое поле readonlyField только для чтения
        ///  должны быть инициализированым в статическом 
        ///  конструкторе.
        /// </summary>
        static readonly long readonlyField = 10;

        /// <summary>
        /// Статическое свойство только для чтения.
        /// </summary>
        public static long ReadonlyField
        {
            get { return MyClass.readonlyField; }
        }

        /// <summary>
        /// Статический конструктор
        /// </summary>
        static MyClass()
        {
            Console.WriteLine("static constructor work");
            readonlyField = 1;
        }
    }
}

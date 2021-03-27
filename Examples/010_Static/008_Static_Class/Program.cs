using System;

/// <summary>
/// Статический класс
/// 1. Экземпляр статического класса нельзя создать.
/// 2. Static class всегда наследуется от Оbject (Попытка наследования от чего либо другого приводит к ошибке компиляции).
/// 3. Static class не реализует интерфейсы. Попытка наследования от интерфейса приводит к ошибке уровня компиляции. 
/// 4. Содержит только статические члены (наличие в нем нестатического члена приведет к ошибке компиляции). 
/// 5. Статический класс не может содержать конструкторов экземпляров.
/// 6. Статический класс закрыт для наследования от него. Попытка наследования от статического класса приводит к ошибке уровня компиляции. 

/// </summary>
namespace _008_Static_Class
{
    class Program
    {
        static void Main()
        {
            MyClass.StaticMethod();

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Статический класс MyClass
    /// </summary>
    static class MyClass: Object/*, IInterface*/
    {
        /// <summary>
        ///  Статический класс не может содержать конструкторов экземпляров.
        /// </summary>
        /*public MyClass()
        {
            Console.WriteLine("Constructor from MyClass work");
        }*/

        /// <summary>
        /// Статический конструктор класса MyClass
        /// </summary>
        static MyClass()
        {
            Console.WriteLine("Static constructor from MyClass work");
        }

        /// <summary>
        /// Статический метод StaticMethod класса MyClass
        /// </summary>
        public static void StaticMethod()
        {
            Console.WriteLine("Static method from MyClass work");
        }
    }

    /// <summary>
    /// Интерфейс IInterface
    /// </summary>
    interface IInterface
    {
        /// <summary>
        /// Метод для реализации в дочернем классе
        /// </summary>
        void Method();
    }
}

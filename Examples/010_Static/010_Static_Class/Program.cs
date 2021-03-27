using System;

/// <summary>
/// Одиночка (англ. Singleton) — порождающий шаблон проектирования, гарантирующий, что в однопоточном приложении будет 
/// единственный экземпляр некоторого класса, и предоставляющий глобальную точку доступа к этому экземпляру.
/// </summary>
namespace _010_Static_Class
{
    class Program
    {
        static void Main()
        {
            //Singleton singleton = new Singleton();

            // Конструктор "protected" - невозможно использовать - new Singleton() 
            Singleton instance1 = Singleton.FactoryMethod();
            Singleton instance2 = Singleton.FactoryMethod();

            if (instance1 == instance2)
            {
                Console.WriteLine("instance1 = instance2");
            }

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс MyClass
    /// </summary>
    class Singleton
    {
        /// <summary>
        /// Статическое поле типа Singleton
        /// </summary>
        private static Singleton singletonField = null;

        protected Singleton(){}

        /// <summary>
        /// Статический Фабричный метод.
        /// </summary>
        public static Singleton FactoryMethod()
        {
            // Если объект еще не создан
            if (singletonField == null)
            {
                // Тогда создаем новый экземпляр
                singletonField = new Singleton();
            }
            // Иначе возвращаем ссылку на существующий объект
            return singletonField;
        }
    }
}

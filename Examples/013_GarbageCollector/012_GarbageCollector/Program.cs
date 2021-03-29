using System;

/// <summary>
/// Воскрешение из мертвых
/// </summary>
namespace _012_GarbageCollector
{
    class Program
    {
        public static MyClass Instanse { get; set; }
        public static int counter;
        static void Main()
        {
            Instanse = new MyClass();

            Instanse = null; //Освобождение объекта
            GC.Collect();

            //Console.ReadKey();

            Instanse = null; //Освобождение объекта
            GC.Collect();

            //Console.ReadKey();
        }
    }

    class MyClass
    {
        ~MyClass()
        {
            Console.WriteLine("Finalize {0}", Program.counter++);

            // При вызове деструтора ссылка на него помещается в живой объект,
            // объект становится живым.
            Program.Instanse = this;

            if (Program.counter < 3)
            {
                // ReRegisterForFinalize - используют для повторного вызова деструктора
                GC.ReRegisterForFinalize(this);
            }
        }
    }
}

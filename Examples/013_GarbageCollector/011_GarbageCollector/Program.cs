using System;
using System.Threading;

/// <summary>
/// Воскрешение из мертвых
/// </summary>
namespace _011_GarbageCollector
{
    class Program
    {
        public static MyClass Instanse { get; set; }
        public static int counter;
        static void Main()
        {
            MyClass myClass = new MyClass();

            //Срабатывает деструктор
            GC.Collect(); //myClass - в очередь смертников

           // Console.ReadKey();

            //Не Срабатывает деструктор, так как на него ссылает жевой обект=>
            //сам объект живой
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
                Thread.Sleep(1000);
            }
        }
    }
}

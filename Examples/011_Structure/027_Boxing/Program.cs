using System;

/// <summary>
/// Упаковка/Распаковка
/// </summary>
namespace _027_Boxing
{
    class Program
    {
        static void Main()
        {
            //Тип значения
            MyStruct myStruct = new MyStruct();
            myStruct.Method();

            //Упаковка
            IInterface boxed = (IInterface)myStruct;
            boxed.Method();

            //Распаковка
            MyStruct unBoxed = (MyStruct)boxed;
            unBoxed.Method();

            //Задержка
            Console.ReadKey();
        }
    }

    interface IInterface
    {
        void Method();
    }

    struct MyStruct : IInterface
    {
        public void Method()
        {
            Console.WriteLine("Method from struct");
        }
    }
}

using System;

namespace _013_GarbageCollector
{
    class Program
    {

        static void test()
        {
            try
            {
                new Exception();
            }
            catch (Exception)
            {
                return;
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
        static void Main()
        {
            test();


            using (MyClass myClass = new MyClass())
            {
                myClass.SomeMethod();
            }

            /*Console.WriteLine(new string('-', 30));

            MyClass myClass1 = new MyClass();

            IDisposable disposable = myClass1 as IDisposable;
            myClass1.Dispose();*/

            Console.ReadKey();
        }
    }

    class MyClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose - {0}", this.GetHashCode());
        }

        public void SomeMethod()
        {
            Console.WriteLine("SomeMethod");
        }
    }
}

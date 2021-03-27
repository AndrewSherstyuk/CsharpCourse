using System;


namespace _013_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            baseClass.Method1();
            baseClass.Method2();

            Console.WriteLine(new string('*', 10));

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method1();
            derivedClass.Method2();

            Console.WriteLine(new string('*', 10));

            AgainDerivedClass againDerivedClass = new AgainDerivedClass();
            againDerivedClass.Method1();
            againDerivedClass.Method2();

            // Задержка.
            Console.ReadKey();
        }
    }

    /// <summary>
    /// BaseClass  - базовый класс
    /// </summary>
    public class BaseClass
    {
        public virtual void Method1() { Console.WriteLine("BaseClass.Method1"); }
        public virtual void Method2() { Console.WriteLine("BaseClass.Method2"); }
    }
 
    class DerivedClass : BaseClass
    {
        sealed public override void Method1() { Console.WriteLine("DerivedClass.Method1"); }
        public override void Method2() { Console.WriteLine("DerivedClass.Method2"); }
    }

    class AgainDerivedClass: DerivedClass
    {
        // Попытка переопределить Method1 приводит к ошибке компилятора: CS0239.
        //public override void Method1() { Console.WriteLine("ClassC.Method1"); }

        // Переопределение Method2 позволено.
        public override void Method2() { Console.WriteLine("ClassC.Method2"); }
    }
}

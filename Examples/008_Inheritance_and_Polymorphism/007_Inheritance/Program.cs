using System;

/// <summary>
/// virtual && override
/// </summary>
namespace _007_Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Method();
            Console.WriteLine(derivedClass.MyProperty);

            Console.WriteLine(new string('*', 10));

            // UpCast
            BaseClass upCastBaseClass = derivedClass;
            upCastBaseClass.Method();
            Console.WriteLine(upCastBaseClass.MyProperty);

            Console.WriteLine(new string('*', 10));

            // DownCast
            DerivedClass downCastDerivedClass = (DerivedClass)upCastBaseClass;
            downCastDerivedClass.Method();
            Console.WriteLine(downCastDerivedClass.MyProperty);

            // Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// DerivedClass - унаследованный от базового класса 
    /// </summary>
    class DerivedClass : BaseClass
    {
        public override int MyProperty { get; set; } = 20;
        
        /// <summary>
        /// Переопределение метода базового класса.
        /// </summary>
        public override void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }

    /// <summary>
    /// BaseClass - базовый класс
    /// </summary>
    class BaseClass
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual int MyProperty { get; set; } = 10;
        
        /// <summary>
        /// Метод из базового класса
        /// </summary>
        public virtual void Method()
        {
            Console.WriteLine("Method from BaseClass");
        }
    }
}

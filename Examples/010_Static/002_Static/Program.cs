using System;

namespace _002_Static
{
    class Program
    {
        static void Main()
        {
            MyClass.Method();

            MyClass myClass = new MyClass(10);
            
            ///на экземпляре myClass нельзя вызвать Method()
            // myClass.Method();

            // На классе-объекте MyClass вызиваем метод Method
            MyClass.Method();

            //Задаржка
            Console.ReadKey();
        } 
    }

    /// <summary>
    /// Класс MyClass
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// Не статическое поле
        /// </summary>
        private int field;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="id"></param>
        public MyClass(int id)
        {
            this.field = id;
        }
        
        /// <summary>
        /// Ститический метод
        /// </summary>
        public static void Method()
        {
            //Console.WriteLine("Instance.Id = {0}", Id);

            Console.WriteLine("В статических методах нельзя обращаться к нестатическим полям.");
        }

    }
}

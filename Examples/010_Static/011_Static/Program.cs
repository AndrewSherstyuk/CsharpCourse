using System;

namespace _011_Static
{
    class Program
    {
        static void Main()
        {
            //Создаем экземпляр класса MyClass с именем myClass1 и myClass2
            MyClass myClass1 = new MyClass(1);
            MyClass myClass2 = new MyClass(2);

            //на экземпляре myClass1 и myClass2 вызиваем метод с именем Method()
            myClass1.Method();
            myClass2.Method();

            Console.WriteLine(new string('-', 30));

            // На классе-объекте MyClass, обращаемся к статическому 
            // полю - staticField и присваеваем ему значение 10
            MyClass.staticField = 10;

            //на экземпляре myClass1 и myClass2 вызиваем метод с именем Method()
            myClass1.Method();
            myClass2.Method();

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
        /// Статическое поле
        /// </summary>
        public static int staticField;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="id"></param>
        public MyClass(int id)
        {
            this.field = id;
        }

        /// <summary>
        /// Метод для отображения ссостояния полей
        /// </summary>
        public void Method()
        {
            Console.WriteLine("Поле = {0}, статическое поле = {1}", field, staticField);
        }
    }
}

using System;

/// <summary>
/// Обработка исключений
/// обработка null
/// </summary>
namespace _014_Exceptions
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass = null;
          
            try
            {
                Console.WriteLine(myClass.MyProperty);

                //throw new Exception("test");
                
            }
            /*catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }*/
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                DateTime.Parse("csdcdss");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }

            // Задержка.
            Console.ReadKey();
        }
    }

    class MyClass
    {
        public int MyProperty { get; set; }
    }
}

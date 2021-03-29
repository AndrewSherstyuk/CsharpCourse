using System;

/// <summary>
/// Обработка исключений
/// </summary>
namespace _009_Exceptions
{
    class Program
    {
        static void Main()
        {
            ClassWithException instance = new ClassWithException();

            // Попробовать вызвать.
            //instance.CatchInner(); 

            try
            {
                instance.CatchInner();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception caught: {0}", exception.Message);
                Console.WriteLine("Inner Exception : {0}", exception.InnerException.Message);
            }

            // Задержка.
            Console.ReadKey();
        }
    }

    public class ClassWithException
    {
        public void ThrowInner()
        {
            throw new Exception("Это внутреннее исключение!");
        }

        public void CatchInner()
        {
            //this.ThrowInner();
            try
            {
                this.ThrowInner();
            }
            catch (Exception e)
            {
                throw new Exception("Это внешнее исключение!", e);
            }
        }
    }
}

using System;

/// <summary>
/// Обработка исключений
/// <summary>
namespace _004_Exceptions
{
    class Program
    {
        static void Main()
        {
            try
            {
                MyClass instance = new MyClass();
                instance.Method();
            }
            catch (Exception e)
            {
                Console.WriteLine("Имя члена:               {0}", e.TargetSite);
                Console.WriteLine("Класс определяющий член: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Тип члена:               {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message:                 {0}", e.Message);
                Console.WriteLine("Source:                  {0}", e.Source);
                Console.WriteLine("Help Link:               {0}", e.HelpLink);
                Console.WriteLine("Stack:                   {0}", e.StackTrace);
            }

            // Задержка.
            Console.ReadKey();
        }
    }

    class MyClass
    {
        public void Method()
        {
            Exception exception = new Exception("Мое исключение");

            exception.HelpLink = "http://MyCompany.com/ErrorService";
            exception.Data.Add("Причина исключения: ", "Тестовое исключение");
            exception.Data.Add("Время возникновения исключения: ", DateTime.Now);

            throw exception;
        }
    }
}

using System;

/// <summary>
/// Написать программу для аутентификации пользователя используя условную конструкцию if - else 
/// </summary>
namespace Conditional_Lessons
{
    class Program
    {
        static void Main()
        {
            //Логин пользователя
            string login = "administrator";
            
            //Пароль пользователя
            string password = "password";

            //Приветствие
            Console.WriteLine("Добро пожаловать! Выполните вход в программу");

            //Запрос логина пользователя
            Console.Write("Введите login: ");

            //Введенный пользователем логин
            string userLogin = Console.ReadLine();

            //Проверка логина
            if (userLogin == login)
            {
                //Если пользователь ввел коректный логин, запрашиваем пароль
                Console.Write("Введите password: ");

                //Введенный пользователем пароль 
                string usersPassword = Console.ReadLine();

                //Проверка логина
                if (usersPassword == password)
                {
                    //Если введенный пароль корректный, приветствуем пользователя
                    Console.WriteLine("Моё почтение {0}, вы успешно аутентифицировались в ситеме!", userLogin);
                }
                else
                {
                    //Если введенный пароль не верный, сообщаем об этом
                    Console.WriteLine("Введенный пароль не корректный!");
                }
            }
            else
            {
                //Если введенный логин не верный, сообщаем об этом
                Console.WriteLine("Введен некорректный login");
            }

            Console.ReadKey();
        }
    }
}

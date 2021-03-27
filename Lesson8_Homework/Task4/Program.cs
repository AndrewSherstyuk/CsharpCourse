using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ENGLISH = "English";
            const string GERMAN = "German";
            const string SPANISH = "Spanish";
            const string CHINESE = "Chinese";
            const string RUSSIAN = "Russian";

            Person ivanov = new Student("Ivan", "Ivanov", 2000, ENGLISH, RUSSIAN, CHINESE, GERMAN, RUSSIAN, SPANISH, ENGLISH);
            Person petrov = new Student("Petr", "Petrov", 1999);
            Person nikitina = new Student("Natalya", "Nikitina", 2001, ENGLISH, GERMAN, SPANISH);
            Person sidorov = new Student("Sidor", "Sidorov", 2000, GERMAN, SPANISH);
            Person vasilyeva = new Student("Irina", "Vasilyeva", 1969, SPANISH);

            Person fedorchuk = new Teacher("Fedor", "Fedorchuk", 1970, nikitina, petrov, sidorov);
            Person lentyaskiy = new Teacher("Lentiay", "Lentiaystkiy", 1985);

            PeopleInfo p = new PeopleInfo(ivanov, fedorchuk, nikitina, sidorov, lentyaskiy, vasilyeva, petrov);
            p.ShowPeople();

            Console.ReadKey();
        }
    }

    class Person
    {
        public int BirthYear { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        protected Person(int b, string n, string s)
        {
            BirthYear = b;
            Name = n;
            Surname = s;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{new string(' ', 5)}{this.Name.ToUpper()} {this.Surname.ToUpper()} (born in {BirthYear})");
            Console.WriteLine($"{new string('=', 40)}");
        }

        public static bool operator >(Person p1, Person p2)
        {
            return p1.BirthYear > p2.BirthYear;
        }

        public static bool operator <(Person p1, Person p2)
        {
            return p1.BirthYear < p2.BirthYear;
        }
    }

    class Student : Person
    {
        private string[] studyCourses;
        private bool moreThanThreeCourses = false;

        public string[] StudyCourses
        {
            get
            {
                return studyCourses;
            }
            set
            {
                if (value.Length <= 3 && value.Length > 0)
                {
                    studyCourses = value;
                }
                else if (value.Length <= 0)
                {
                    studyCourses = new string[0];
                }
                else
                {
                    studyCourses = new string[3];
                    
                    for (int i = 0; i < 3; i++)
                    {
                        studyCourses[i] = value[i];
                    }
                    moreThanThreeCourses = true;
                }
            }
        }

        public Student(string name, string surname, int birthYear, params string[] courses) : base(birthYear, name, surname)
        {
            StudyCourses = courses;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine("S T U D E N T , the list of courses taken:");

            if (studyCourses.Length > 0 && studyCourses.Length <= 3)
            { 
                for (int i = 0; i < studyCourses.Length; i++)
                {
                    Console.WriteLine($"{studyCourses[i]} ");
                }

                if (moreThanThreeCourses)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{this.Name} selected more than 3 courses to study, \nso we selected those 3 above for him."); 
                    Console.ResetColor();
                }
            }
            
            if (studyCourses.Length <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{this.Name} didn't select any courses to study. \nIt's OK: Someone should do cleaner's job.");
                Console.ResetColor();
            }
            
            Console.WriteLine("\n");
        }
    }

    class Teacher : Person
    {
        private Person[] studentsArray;

        public Person[] StudentsArray
        {
            get
            {
                return studentsArray;
            }
            set
            {
                studentsArray = value;
            }
        }

        public Teacher(string name, string surname, int birthYear, params Person[] students) : base(birthYear, name, surname)
        {
            StudentsArray = students;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine("T E A C H E R , the list of students assigned:");

            if (studentsArray.Length > 0 )
            {
                for (int i = 0; i < studentsArray.Length; i++)
                {
                    Console.WriteLine($"{studentsArray[i].Name} {studentsArray[i].Surname} ");
                }
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{this.Name} doestn't teach any students. \nIt's OK: They're applied to janitor's position.");
                Console.ResetColor();
            }

            Console.WriteLine("\n");
        }
    }

    class PeopleInfo
    {
        private Person[] peopleArray;

        public Person[] PeopleArray
        {
            get
            {
                return peopleArray;
            }
            set
            {
                peopleArray = value;
            }
        }

        public PeopleInfo(params Person[] peopleArray)
        {
            PeopleArray = peopleArray;
        }

        public void ShowPeople()
        {
            Person temp;

            for (int i = 0; i < peopleArray.Length - 1; i++)
            {
                for (int j = i + 1; j < peopleArray.Length; j++)
                {
                    if (peopleArray[i] > peopleArray[j])
                    {
                        temp = peopleArray[i];
                        peopleArray[i] = peopleArray[j];
                        peopleArray[j] = temp;
                    }
                }
            }

            for (int k = 0; k < peopleArray.Length; k++)
            {
                peopleArray[k].ShowInfo();
            }
        }
    }
}

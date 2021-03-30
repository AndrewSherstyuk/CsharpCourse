using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForLesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Workman("Johnson", 35, 1550.70, "Engineering");
            Employee e2 = new Workman("Kohl", 24, 1830.55, "Support");
            Employee e3 = new Workman("Barns", 48, 1658.32, "Support");
            Employee e4 = new Workman("Nikolsky", 52, 2350.60, "Engineering");

            Employee e5 = new Director("Willis", 33, 3500.00, (Workman)e1, (Workman)e3);
            Employee e6 = new Director("Doe", 38, 3880.00, (Workman)e2, (Workman)e4);

            Employee[] employees = new Employee[] { e1, e2, e6, e4, e5, e3 };

            foreach(Employee e in employees)
            {
                if (e is Workman)
                {
                    Console.WriteLine((e as Workman).ToString());
                }
                if (e is Director)
                {
                    Console.WriteLine((e as Director).ToString());
                }
            }

            Console.WriteLine("\n\n");

            Salary sal_1 = new Salary(employees);
            
            Console.WriteLine($"SALARIES BEFORE INDEXATING \n{new string ('=', 60)} {sal_1.ToString()}");

            sal_1.ChangeSalaries(10, ref employees);

            Salary sal_2 = new Salary(employees);

            Console.WriteLine($"\nSALARIES AFTER INDEXATING \n{new string('=', 60)} {sal_2.ToString()}");

            Console.ReadKey();
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(string n, int a, double s)
        {
            Name = n;
            Age = a;
            Salary = s;
        }

        public string ShowInfo()
        {
            return $"NAME - {Name} \nAGE - {Age} \nSALARY - {Salary}";
        }
    }

    class Workman : Employee
    {
        public string Department { get; set; }

        public Workman(string n, int a, double s, string d) : base(n, a, s)
        {
            Department = d;
        }

        public override string ToString()
        {
            return "W O R K M A N\n" + new string('=', 30) + "\n" + this.ShowInfo() + $"\nDEPARTMENT - {Department}\n";
        }

    }

    class Director : Employee
    {
        public Workman[] Workmen { get; set; }

        public Director(string n, int a, double s, params Workman[] w) : base(n, a, s)
        {
            Workmen = w;
        }

        public override string ToString()
        {
            return "D I R E C T O R\n" + new string('=', 30) + "\n" + this.ShowInfo() + $"\nNUMBER OF EMPLOYEES ASSIGNED - {Workmen.Length}\n";
        }
    }

    class Salary
    {
        public Employee[] Employees;
        public Salary(params Employee[] employees)
        {
            Employees = employees;
        }
        public void ChangeSalaries(int changeRate, ref Employee[] employees1)
        {
            foreach(Employee e in employees1)
            {
                e.Salary += e.Salary * changeRate / 100;
            }
        }

        public override string ToString()
        {
            string a = String.Empty;

            foreach(Employee e in Employees)
            {
                a += $"\n{e.Name} - {e.Salary}";
            }
            return a;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount(0.20m, 1000m);
           
            myAccount.Year = 2020;
            
            myAccount.Month = 3;
            
            myAccount.Day = 10;

            myAccount.countDaysSinceAccountWasCreated(DateTime.Today);

            myAccount.showDaysSinceAccountWasCreated();

            myAccount.calculateSumInSomeYears(5);

            myAccount.showSumInSomeYears();

            Console.ReadKey();
        }
    }

    class BankAccount
    {
        private int year, month, day;

        public int Year
        {
            set
            {
                year = value;
            }
        }

        public int Month
        {
            set
            {
                month = value;
            }
        }

        public int Day
        {
            set
            {
                day = value;
            }
        }

        private decimal interestRate;

        private decimal totalAmount;

        private string numberOfDays;

        private int numberOfYears;

        public BankAccount(decimal interestRate, decimal totalAmount)
        {          
            this.interestRate = interestRate;

            this.totalAmount = totalAmount;            
        }

        public string countDaysSinceAccountWasCreated(DateTime date)
        {
            DateTime creationDate = new DateTime(year, month, day);            

            TimeSpan number = date - creationDate;

            numberOfDays = number.TotalDays.ToString();

            return numberOfDays;
        }

        public void showDaysSinceAccountWasCreated()
        {
            Console.WriteLine($"Number of days since the account was created: \t{numberOfDays}");
        }

        public decimal calculateSumInSomeYears(int numberOfYears)
        {
            this.numberOfYears = numberOfYears;
            
            for (int i = 0; i < numberOfYears; i++)
            {
                totalAmount += totalAmount * interestRate;
            }

            return totalAmount;
        }

        public void showSumInSomeYears()
        {
            Console.WriteLine($"In {numberOfYears} year the sum will be: \t\t\t{Math.Round(totalAmount, 2)}");
        }
    }
}

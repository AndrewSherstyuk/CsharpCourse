using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address a = new Address();

            a.Country = "Ukraine";

            a.City = "Kharkiv";

            a.Street = "Sumska";

            a.HouseNumber = "1";

            a.AppNumber = 1;

            a.PostCode = 61026;

            a.PrintAddress();

            Console.ReadKey();
        }
    }

    class Address
    {
        private string country;

        private string city;

        private string street;

        private string houseNumber;

        private int appNumber;

        private int postCode;

        public string Country
        {
            set
            {
                country = value;
            }            
            get
            {
                return country;
            }        
        }

        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }

        public string Street
        {
            set
            {
                street = value;
            }
            get
            {
                return street;
            }
        }

        public string HouseNumber
        {
            set
            {
                houseNumber = value;
            }
            get
            {
                return houseNumber;
            }
        }

        public int AppNumber
        {
            set
            {
                appNumber = value;
            }
            get
            {
                return appNumber;
            }
        }

        public int PostCode
        {
            set
            {
                postCode = value;
            }
            get
            {
                return postCode;
            }
        }

        public void PrintAddress()
        {
            Console.WriteLine($"The address is: {postCode}, {country}, {city}, {houseNumber} {street} str., app. {appNumber}");
        }
    }
}

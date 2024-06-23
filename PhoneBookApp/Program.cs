using PhoneBookApp.Models;
using PhoneBookApp.Service;
using System;

namespace PhoneBookApp
{
    internal class Program
    {
        private static string phone;
        private static object name;

        static void Main(string[] args)
        {
            PhoneBook myPhone = new PhoneBook()
            {
                phone = "995003530",
                name = "Sunatilla"
            };

            PhoneBookServices phoneBookServices = new PhoneBookServices();
            phoneBookServices.ShowAllData(myPhone);
            
            Console.ReadLine();

        }
    }
}

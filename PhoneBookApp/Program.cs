using PhoneBookApp.Models;
using PhoneBookApp.Service;
using System;

namespace PhoneBookApp
{
    internal class Program
    {
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

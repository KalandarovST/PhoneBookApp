using System;
using PhoneBookApp.Models;


namespace PhoneBookApp.Service
{
    internal class PhoneBookServices
    {
        private string phone;
        private string name;
        private object phoneBook;

        public void ShowAllData(PhoneBook phoneBook)
        {
            Console.WriteLine($" Name: {phoneBook.name}");
            Console.WriteLine($" Phone: {phoneBook.phone}");

        }
    }
}

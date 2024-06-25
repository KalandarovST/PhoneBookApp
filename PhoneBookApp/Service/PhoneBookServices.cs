using System;
using System.Collections.Generic;
using PhoneBookApp.Models;


namespace PhonebookApp.Services;

public class ContactServices
{
     List<Contact> contactList = [];
    public void ShowMenu(string message)
    {
        Console.WriteLine(message);
    }
    public void AddContact()
    {
        Console.Write("ism kiriting: ");
        string name = Console.ReadLine();
        Console.Write("telefon raqam kiriting: ");
        string phone = Console.ReadLine();
        Contact contact = new Contact();

        contact.InputName = name;
        contact.InputNumber = phone;
        contactList.Add(contact);
    }
    public void RemoveContact()
    {
        Console.Write("ism kiriting: ");
        string name = Console.ReadLine();
        contactList.RemoveAll(r => r.InputName == name);
    }
    public void EditContact()
    {
        Console.Write("Kimni kontaktini o'gartirmoqchisiz?, (ismini kiriting): ");
        string name = Console.ReadLine();
        bool isContactExist = contactList.Exists(r => r.InputName == name);
        if (isContactExist)
        {
            contactList.Find(r => r.InputName == name).phone = Console.ReadLine();
            Console.WriteLine("contact is successfully changed");
        }
        else
        {
            Console.WriteLine("not found this contact");
        }
    }

    public void ExistedContacts()
    {
        Contact contact1 = new Contact();
        contact1.InputName = "Sunatilla";
        contact1.InputNumber = "914203514";
        contactList.Add(contact1);

    }
    public void ReadAllContacts()
    {
        foreach (Contact contact in contactList)
        {
            Console.WriteLine($"Name {contact.InputName},\n Phone number {contact.InputNumber}");
        }
    }
}

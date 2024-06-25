using PhonebookApp.Services;

namespace PhonebookApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContactServices contactServices = new ContactServices();
            contactServices.ExistedContacts();
            contactServices.ReadAllContacts();
            contactServices.AddContact();
            contactServices.RemoveContact();
            contactServices.EditContact();
            contactServices.ReadAllContacts();
        }
    }
}
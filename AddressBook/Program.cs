using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adress Book program..... ");
            Contact contact = new Contact();
            AddressBookMain createContact = new AddressBookMain();
            createContact.CreateContact();
        }
    }
}
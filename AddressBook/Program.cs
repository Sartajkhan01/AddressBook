using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Address Book Program\n===================================");
            AddressBookMain addingContact = new AddressBookMain();
            bool end = true;
            while (end)
            {
                Console.WriteLine("Choose an option to execute :\n1. Create Contact\n2. Add Contact\n3. Edit Contact\n4." +
                    " Delete Contact\n5. View Contact\n6. Restricting Duplicate Contact\n7. End The Program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addingContact.AddContact();
                        Console.WriteLine("Contact has created");
                        break;
                    case 2:
                        addingContact.AddContact();
                        Console.WriteLine("Contact has added ");
                        addingContact.Display();
                        break;
                    case 3:
                        addingContact.EditContact();
                        break;
                    case 4:
                        addingContact.DeleteContact();
                        break;
                    case 5:
                        addingContact.ViewContact();
                        break;
                    case 6:
                        MultipleAddressBook studentAddressBook = new MultipleAddressBook();
                        studentAddressBook.AddDetails("Engineer", "Sartaj", "Khan", "Whitefield", "Nagpur", "Maharashtra", 4400002, 9424777313, "sartajikhan786@gmail.com");
                        studentAddressBook.AddDetails("Engineer", "Abhishek", "Jadhav", "Bandra", "Mumbai", "Maharashtra", 560464, 1236547899, "sartajikhan786@gmail.com");
                        studentAddressBook.AddDetails("Engineer", "Shivraj", "Gawda", "Malleshwaram", "Bengaluru", "karnataka", 560066, 9424464313, "sartajikhan786@gmail.com");
                        studentAddressBook.AddDetails("Engineer", "Rajesh", "Singh", "GTNagar", "pune", "Maharashtra", 564566, 9433777313, "sartajikhan786@gmail.com");
                        studentAddressBook.AddDetails("Engineer", "Vivek", "Singh", "HSR", "Bengaluru", "karnataka", 560996, 9424777315, "sartajikhan786@gmail.com");
                        studentAddressBook.AddDetails("Engineer", "Siddhant", "Singh", "City Centre", "Noida", "U.P.", 458963, 9425477313, "sartajikhan786@gmail.com");
                        Console.WriteLine("Enter Engineer Address Book Name : ");
                        string addressBook = Console.ReadLine();
                        studentAddressBook.AddressBook(addressBook);
                        studentAddressBook.ComputeDetails();
                        studentAddressBook.Search();
                        studentAddressBook.Count();
                        break;
                    case 7:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option ");
                        break;
                }
            }

        }
    }
}
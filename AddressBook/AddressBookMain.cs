using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        Contact contact = new Contact();
        List<Contact> addressBook = new List<Contact>();
        public void CreateContact()
        {
            Console.WriteLine("Enter First Name : ");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address : ");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City : ");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State : ");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Zip Code : ");
            contact.Zipcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number : ");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email Address : ");
            contact.Email = Console.ReadLine();
            addressBook.Add(contact);
        }
        public void Display()
        {
            foreach (var contact in addressBook)
            {
                Console.WriteLine("First Name : " + contact.FirstName + "\nLast Name : " + contact.LastName + "\nAddress : " + contact.Address + "\nCity : " + contact.City
                    + "\nState : " + contact.State + "\nZip Code : " + contact.Zipcode + "\nPhone Number : " + contact.PhoneNumber + "\nEmail Address : " + contact.Email);
            }
        }
        public void EditContact()
        {
            Console.WriteLine("For editing a contact enter first name : ");
            string name = Console.ReadLine();
            if (contact.FirstName == name)
            {
                Console.WriteLine("Edit a contact\n1. Last Name\n2. Address\n3. City\n4. State\n5. ZipCode\n6. Phone Number\n7. Email Address");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        string lastName = Console.ReadLine();
                        contact.LastName = lastName;
                        break;
                    case 2:
                        string address = Console.ReadLine();
                        contact.Address = address;
                        break;
                    case 3:
                        string city = Console.ReadLine();
                        contact.City = city;
                        break;
                    case 4:
                        string state = Console.ReadLine();
                        contact.State = state;
                        break;
                    case 5:
                        string zipcode = Console.ReadLine();
                        contact.Zipcode = Convert.ToInt32(zipcode);
                        break;
                    case 6:
                        string phone = Console.ReadLine();
                        contact.PhoneNumber = Convert.ToInt64(phone);
                        break;
                    case 7:
                        string email = Console.ReadLine();
                        contact.Email = email;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Contact doesn't exist");
            }
        }
        public void DeleteContact()
        {
            Contact delete = new Contact();
            Console.WriteLine("For deleting a contact enter first name :");
            string name = Console.ReadLine();
            foreach (var contact in addressBook)
            {
                if (contact.FirstName == name)
                {
                    delete = contact;
                }
            }
            addressBook.Remove(delete);
            Display();
        }
    }
}

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
    }
}

using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book
{
    internal class AddressBookImpl : IAddressBook
    {
        // Holds the details of a single contact
        private Contact contact;

        //UC 1:Ability to create a Contacts in Address Book with first and last names, address,city, state, zip, phone number and email
        public void AddContact()
        {
            contact = new Contact(); // Create a new Contact object

            // Get contact details from user input
            Console.Write("Enter First Name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter State: ");
            contact.State = Console.ReadLine();

            Console.Write("Enter Zip: ");
            contact.Zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            contact.Email = Console.ReadLine();

            Console.WriteLine("\nContact Added Successfully\n"); // Confirmation message
        }
        //UC-2:Ability to add a new contact to Address Book
        public void EditContact()
        {
            // Check if contact exists
            if (contact == null)
            {
                Console.WriteLine("No contact available to edit\n");
                return;
            }

            Console.Write("Enter First Name to Edit Contact: ");
            string name = Console.ReadLine();

            // Match contact using first name
            if (contact.FirstName.Equals(name))
            {
                Console.Write("Enter New Address: ");
                contact.Address = Console.ReadLine();

                Console.Write("Enter New City: ");
                contact.City = Console.ReadLine();

                Console.Write("Enter New State: ");
                contact.State = Console.ReadLine();

                Console.Write("Enter New Zip: ");
                contact.Zip = Console.ReadLine();

                Console.Write("Enter New Phone Number: ");
                contact.PhoneNumber = Console.ReadLine();

                Console.Write("Enter New Email: ");
                contact.Email = Console.ReadLine();

                Console.WriteLine("\nContact Updated Successfully\n");
            }
            else
            {
                Console.WriteLine("Contact Not Found\n");
            }
        }
        }
}

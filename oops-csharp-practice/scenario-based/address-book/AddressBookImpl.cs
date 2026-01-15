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

        //UC-2:Ability to add a new Contact to Address Book
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
        //UC-3:Ability to add a new Contact to Address Book
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
        //UC-4:Ability to delete a person using person's name
        public void DeleteContact()
        {
            // Check if contact exists
            if (contact == null)
            {
                Console.WriteLine("No contact available to delete\n");
                return;
            }

            Console.Write("Enter First Name to Delete Contact: ");
            string name = Console.ReadLine();

            // Match contact by first name
            if (contact.FirstName.Equals(name))
            {
                contact = null; // Removing reference deletes the contact
                Console.WriteLine("\nContact Deleted Successfully\n");
            }
            else
            {
                Console.WriteLine("Contact Not Found\n");
            }
        }

        public void AddMultipleContactsMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Add Multiple Contacts ---");
                Console.WriteLine("1. Add New Contact");
                Console.WriteLine("0. Go Back");
                Console.Write("Enter Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddContact();
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 0);
        }
    }
}

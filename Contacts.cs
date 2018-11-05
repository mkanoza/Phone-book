using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace homework
{
    class Contacts : Utils
    {
        private Utils utils = new Utils();

        ContactsRepository contactsRepository;

        public Contacts(ContactsRepository contactsRepository)
        {
            this.contactsRepository = contactsRepository;
        }

        public void AddContact()
        {
            utils.SetColorToGreen();
            Console.WriteLine("Fill contact details");
            Console.Write("Fill contact name: ");
            utils.ResetColor();
            string contactName = Console.ReadLine();Console.WriteLine("");

            while (!Regex.IsMatch(contactName, @"^(?!\s*$).+"))
            {
                utils.SetColorToRed();
                Console.WriteLine("Name cannot be empty");
                utils.SetColorToGreen();
                Console.Write("Fill name once again: ");
                utils.ResetColor();
                contactName = Console.ReadLine();
            }

            utils.SetColorToGreen();
            Console.Write("Fill contact surname: ");
            utils.ResetColor();
            string contactSurname = Console.ReadLine();  Console.WriteLine("");

            while (!Regex.IsMatch(contactSurname, @"^(?!\s*$).+"))
            {
                utils.SetColorToRed();
                Console.WriteLine("Surname cannot be empty");
                utils.SetColorToGreen();
                Console.Write("Fill surnname once again: ");
                utils.ResetColor();
                contactSurname = Console.ReadLine();
            }

            utils.SetColorToGreen();
            Console.Write("Fill mobile phone number: ");
            utils.ResetColor();
            string mobilePhone = Console.ReadLine();

            while (!Regex.IsMatch(mobilePhone, "^[0-9]*$"))
            {
                utils.SetColorToRed();
                Console.WriteLine("Mobile phone should only have numbers");
                utils.SetColorToGreen();
                Console.Write("Fill mobile phone once again: ");
                utils.ResetColor();
                mobilePhone = Console.ReadLine();
            }

            string contactDetails = $"{contactName} {contactSurname} {mobilePhone}";
            contactsRepository.AddContact(contactDetails);
            Console.Clear();
            Console.WriteLine("Contact {0} was added to contact list", contactDetails);
            Console.WriteLine("");
        }

        public void DeleteContact()
        {
            string contact = FindContact();
            Console.WriteLine(contact);
            Console.WriteLine("Do you really want to delete this contact? (y)es, (n)o ");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "y":
                    Console.Clear();
                    contactsRepository.DeleteContact(contact);
                    Console.WriteLine("Contact has been deleted");
                    break;
            }
        }

        public void ShowContacts()
        {
            var contactList = contactsRepository.showAllContacts();

            Console.WriteLine("Contacts in phone book: ");

            foreach (string contact in contactList)
            {
                Console.WriteLine(contact);
            }

            Console.WriteLine("");
        }

        public string FindContact()
        {
            utils.SetColorToGreen();
            Console.WriteLine("Fill contact name or surname or mobile phone");
            utils.ResetColor();
            string contactDetials = Console.ReadLine();
            var contactList = contactsRepository.showAllContacts();
            string foundContact = null;

            foreach (var contact in contactList)
            {
                if (contact.Contains(contactDetials))
                {
                    foundContact = contact;
                }
            }

            return foundContact;
        }

        public void showFoundedContact()
        {
            Console.WriteLine(FindContact());
            Console.WriteLine("");
        }
    }
}
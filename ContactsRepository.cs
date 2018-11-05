using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class ContactsRepository
    {
        private static List<string> contactList = new List<string>
        {
            "Robert Kowalski 789789789",
            "Tester Testowy 123456789",
            "Adam Adamski 222333444",
            "Adam Adamski 555666777",
        };

        public void AddContact(string contact)
        {
            contactList.Add(contact);
        }

        public void DeleteContact(string contact)
        {
            contactList.Remove(contact);
        }

        public List<string> showAllContacts()
        {
            return contactList;
        }

    }
}

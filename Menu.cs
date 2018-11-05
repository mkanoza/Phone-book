using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Menu : MenuStructure
    {
        Utils utils = new Utils();

        public void MainMenu(Contacts contacts)
        {
            bool switchLoop = true;

            while (switchLoop)
            {
                string menuOption = ShowMenu(mainMenuStructure);

                switch (menuOption)
                {
                    case "1":
                        AddContactSubMenu(contacts, addContactStructure);
                        break;
                    case "2":
                        DeleteContactSubMenu(contacts, deleteContactStructure);
                        break;
                    case "3":
                        ShowContactSubMenu(contacts, showContactStructure);
                        break;
                    case "4":
                        FindContactSubMenu(contacts, findContactStructure);
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public string ShowMenu(List<string> menuStructure)
        {
            foreach (String menuOption in menuStructure)
            {
                Console.WriteLine(menuOption);
            }

            utils.SetColorToGreen();
            Console.WriteLine("Select option from menu");
            utils.ResetColor();
            string selectedOption = Console.ReadLine();
            Console.Clear();
            return selectedOption;
        }

        public void AddContactSubMenu(Contacts contacts, List<string> subMenu)
        {
            bool switchLoop = true;

            while (switchLoop)
            {
                string menuOption = ShowMenu(subMenu);
                switch (menuOption)
                {
                    case "1.1":
                        contacts.AddContact();
                        break;
                    case "1.2":
                        MainMenu(contacts);
                        break;
                }
            }
        }

        public void DeleteContactSubMenu(Contacts contacts, List<string> subMenu)
        {
            bool switchLoop = true;

            while (switchLoop)
            {
                string menuOption = ShowMenu(subMenu);
                switch (menuOption)
                {
                    case "2.1":
                        contacts.DeleteContact();
                        break;
                    case "2.2":
                        MainMenu(contacts);
                        break;
                }
            }
        }

        public void ShowContactSubMenu(Contacts contacts, List<string> subMenu)
        {
            bool switchLoop = true;

            while (switchLoop)
            {
                string menuOption = ShowMenu(subMenu);
                switch (menuOption)
                {
                    case "3.1":
                        contacts.ShowContacts();
                        break;
                    case "3.2":
                        MainMenu(contacts);
                        break;
                }
            }
        }

        public void FindContactSubMenu(Contacts contacts, List<string> subMenu)
        {
            bool switchLoop = true;

            while (switchLoop)
            {
                string menuOption = ShowMenu(subMenu);
                switch (menuOption)
                {
                    case "4.1":
                        contacts.showFoundedContact();
                        break;
                    case "4.2":
                        MainMenu(contacts);
                        break;
                }
            }
        }
    }
}
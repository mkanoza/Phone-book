using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /* zalozenia projektowe
            1. Dane bedziemy przechowywac w pamieci
            2. Dodawanie i usuwanie, wyszukiwanie
            3. Przechowywane dane: imie, nazwisko, numer telefonu
            4. Komunikaty : wymagane pole, walidacje danych, typy pol (imie nazwisko -string, nr tel - int), 
            5. Aplikacja dziala, dopoki nie zostanie zamknieta przez uzytkownika
            6. Menu
            7. Unit testy
            */

            Menu menu = new Menu();
            ContactsRepository contactsRepository = new ContactsRepository();
            Contacts contacts = new Contacts(contactsRepository);
            menu.MainMenu(contacts);                  
        }

    }
    }




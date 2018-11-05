using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class MenuStructure
    {
        public static List<string> mainMenuStructure = new List<string>
        {
            "---------Phone book--------",
            "1. Add contacts.",
            "2. Delete contacts.",
            "3. Show contacts.",
            "4. Find contacts.",
            "5. Exit",
            "----------------------------"
        };

        public static List<string> addContactStructure = new List<string>
        {
            "--------1. Add contacts--------",
            "1.1 Add a contact",
            "1.2 Back",
            "-------------------------------"
        };

        public static List<string> deleteContactStructure = new List<string>
        {
            "--------2. Delete contacts--------",
            "2.1 Delete a contact",
            "2.2 Back",
            "----------------------------------"
        };

        public static List<string> showContactStructure = new List<string>
        {
            "--------3. Show contacts--------",
            "3.1 Show all contacts",
            "3.2 Back",
            "--------------------------------"
        };

        public static List<string> findContactStructure = new List<string>
        {
            "--------4. Find contacts--------",
            "4.1 Find a contact",
            "4.2 Back",
            "--------------------------------"
        };
    }
}

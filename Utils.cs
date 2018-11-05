using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Utils
    {
        public void SetColorToGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void SetColorToRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void ResetColor()
        {
            Console.ResetColor();
        }
    }
}

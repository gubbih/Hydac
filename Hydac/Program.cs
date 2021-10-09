using System;

namespace Hydac
{
    class Program
    {
        static void Main(string[] args)
        {

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu.Forside();
            }
        }

    }
}

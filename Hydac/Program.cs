using System;

namespace Hydac
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gæst = false;
            bool medarbejderLogin = false;
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu.Forside();
            }
            while (medarbejderLogin)
            {
                showMenu = Menu.Mlogin();
            }
        }

    }
}

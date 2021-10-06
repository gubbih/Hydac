using System;
using System.Collections.Generic;
using System.Text;

namespace Hydac
{
    class Menu
    {
        public string Password;
        public string Username;
        public bool gæst = false;
        public static bool Forside()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Gæst");
            Console.WriteLine("2) Medarbejder Login: ");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    //Gæst();

                    return true;
                case "2":
                    Mlogin();

                    return false;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
        public static bool Mlogin()
        {
            string Username;
            Console.Clear();
            Console.WriteLine("Bruger Navn:");
            Username = Console.ReadLine();
            Console.WriteLine("Password:");
            string Password = Console.ReadLine();
            DateTime localDate = DateTime.Now;
            if (Password != "")
            {
                Console.Clear();
                Console.WriteLine("Du er checked in, din ankomst tid er " + localDate);
                Console.WriteLine();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Smiley");
                Console.WriteLine("2) Updatere din info ");
                Console.WriteLine("3) Book et møde ");
                Console.WriteLine("4) Jeg går hjem ");
                Console.WriteLine("5) Logud");
                switch (Console.ReadLine())
                {
                    case "1":
                        //ReverseString();

                        return true;
                    case "2":
                        Mlogin();
                        return true;
                    case "3":
                        return false;
                    default:
                        return true;
                }
            }
            else
            {
                Forside();
                return false;
            }




        }
    }

}

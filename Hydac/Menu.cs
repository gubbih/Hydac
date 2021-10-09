using System;
using System.Collections.Generic;
using System.Text;

namespace Hydac
{
    public class Menu
    {
        public string Password;
        public string Username;
        public bool gæst = false;
        public static bool Forside()
        {
            
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Gæste check-in");
            Console.WriteLine("2) Medarbejder Login: ");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1": // Gæste check-in
                    Gæst();

                    return true;
                case "2": //Medarbejder login
                    Mlogin();

                    return false;
                case "3": //exit
                    Admin_Save();
                    return true;
                default:
                    return true;
            }
        }
        private static string Gæst()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Gæste check-in");
            Console.WriteLine("2) Gæste check-ud ");
            Console.WriteLine("3) Tilbage");
            switch (Console.ReadLine())
            {
                case "1": // Gæste check-in
                    Gcheckin();

                    return "true";
                case "2": // Gæste check-ud
                    //Gcheck();

                    return "true";

                default:
                    Forside();
                    return "true";
            }
            
        }
        private static string Gcheckin() // skal rykkes over i en anden class (for at det hele ser pænere ud og den er nemmere og finde)
        {
            Console.Clear();
            bool BG_read;
            DateTime localDate = DateTime.Now;
            Console.WriteLine("Du er i gang med at checke dig ind på dette tidspunkt: " + localDate);
            Console.WriteLine("Indtast dit navn:");
            string Gnavn = Console.ReadLine();
            Console.WriteLine("Har du læst reglerne?");
            Console.WriteLine("ja/nej");
            string G_read = Console.ReadLine();
            if (G_read == "ja")
            {
                bool.TryParse(G_read, out BG_read);
                BG_read = true;
            }else if (G_read == "nej")
            {
                bool.TryParse(G_read, out BG_read);
                BG_read = false;
            }
            else
            {
                Console.WriteLine("der skete en fejl, du kommer tilbage til forsiden");
                Console.WriteLine("tryk på enter for at forsætte");
                Console.ReadLine();
                Forside();
            }
            Console.Clear();
            Console.WriteLine("vælg en medarbejder");
            Console.WriteLine("1. Torben");// Intet array endnu, men har klar gjort et array med en for
            /*for (int i = 0; i < Person.length; i++)
            {
                int y = 0
                y = i + 1;
                Console.WriteLine(y + " " + Person[i]);
            }*/

            string medarbejder = Console.ReadLine();
            /*for (int i = 0; i < Person.length; i++)
            {
                if (i == medarbejder)
                {
                    fidner ledsager navn og gemmer det hos gæstens datafil
                }
                
            }*/
            

            return "";
        }

        private static bool Mlogin()
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
                //Console.WriteLine("Du er checked in, din ankomst tid er " + localDate); Bruger en methode til at checke ind nu
                //Console.WriteLine();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Smiley");
                Console.WriteLine("2) Updatere din info ");
                Console.WriteLine("3) Book et møde ");
                Console.WriteLine("4) Check ind ");
                Console.WriteLine("5) Check ud ");
                Console.WriteLine("6) Logud");
                switch (Console.ReadLine())
                {
                    case "1":// smiley
                        //Smiley();

                        return true;
                    case "2"://update
                        Mlogin();
                        return true;
                    case "3"://book møde
                        return false;
                    case "4"://Check ind
                        return false;
                    case "5": // Cehck ud
                        return false;
                    default://logud
                        Forside();
                        return true;
                }
            }
            else
            {
                Forside();
                return false;
            }

            //Person person = new Person("Anders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);
        }
        private static string Admin_Save()
        {
            DataHandler handler = new DataHandler("medarbejder.txt");
            Console.WriteLine("name");
            
            string name = Console.ReadLine();
            Console.WriteLine("password");
            string password = Console.ReadLine();
            Medarbejder person = new Medarbejder(name,password);
            handler.SavePerson(person);
            return "";
        }
    }

}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Hydac
{
    class Medarbejder
    {
        private string name;
        private string password;
        private int smiley = 0;
        private DateTime checkIn;
        private DateTime checkUd;
        private bool iBygning = false;
        
        // navn:Password:smiley:checkin:checkud:IBygning:

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Password  // kunne bruge en encrypter der hedder: string encryptedString = SomeStaticClass.Encrypt(sourceString);
                                //string decryptedString = SomeStaticClass.Decrypt(encryptedString);
        {

            set { password = value; }
            get { return password; }
        }
        public int Smiley
        {
            get { return smiley; }
            set { smiley = value; }
        }
        public DateTime CheckIn
        {
            set { checkIn = value; }
            get { return checkIn; }
        }
        public DateTime CheckUd
        {
            set { checkUd = value; }
            get { return checkUd; }
        }
        public bool IBygning
        {
            set { iBygning = value; }
            get { return iBygning; }
        }
        public string MakeTitle()
        {
            return $"{name};{password};{smiley};{checkIn};{checkUd}"; // data skal ændres

        }
        public Medarbejder(string name, string password,int smiley, DateTime checkIn, DateTime checkUd, bool iBygning)
        {
            Name = name;
            Password = password;
            Smiley = smiley;
            CheckIn = checkIn;
            CheckUd = checkUd;
            IBygning = iBygning;


        }
        public Medarbejder[] LoadedMedarbejder;
        public Medarbejder LoadMedarbejder()
        {
            Medarbejder medarbejder;
            string line;
            string[] a_medarbejder = new string[5];
            StreamReader sr = null;
                try
                {
                    sr = new StreamReader("medarbejdere.txt");
                    line = sr.ReadLine();
                    a_medarbejder = line.Split(';');
                }
                catch (Exception e)
                {
                    Console.WriteLine(" Exception: " + e.Message);
                }
                finally
                {
                    if (sr != null)
                        sr.Close();
                }
            
            medarbejder = new Medarbejder(a_medarbejder[0], string.Parse(a_medarbejder[1]), double.Parse(a_medarbejder[2]), bool.Parse(a_medarbejder[3]), int.Parse(a_medarbejder[4]));
            return medarbejder;

         }
        public void SaveMedarbejder(Medarbejder[] medarbejder)
        {
            StreamWriter sw = new StreamWriter("medarbejdere.txt");
            for (int i = 0; i < medarbejder.Length; i++)
            {
                if (medarbejder[i] == null)
                {
                    break;
                }
                sw.WriteLine(medarbejder[i].MakeTitle());
            }
            sw.Close();
            
        }
    }
    class Dagslog
    {

    }
}

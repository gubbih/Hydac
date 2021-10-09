using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Hydac
{
    public class Medarbejder
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
        public string StringSave()
        {
            return $"{name};{password}"; // data skal ændres

        }
        public Medarbejder(string name, string password, int smiley, DateTime checkIn, DateTime checkUd, bool iBygning)
        {// Bruges til hverdag når man møder ind
            Name = name;
            Password = password;
            Smiley = smiley;
            CheckIn = checkIn;
            CheckUd = checkUd;
            IBygning = iBygning;
        }
        public Medarbejder(string name, string password)// bruger kun de værdier vi skal bruge til at lave brugeren, resten kommer på når man møde ind på arbejde
        {
            Name = name;
            Password = password;
            
        }
        public Medarbejder[] LoadedMedarbejder;     

        
    }
    public class DataHandler
    {
        private string dataFileName;
        public string DataFileName
        {
            get { return dataFileName; }
        }
        public DataHandler(string dataFileName)
        {
            this.dataFileName = dataFileName;
        }

        public void SavePerson(Medarbejder medarbejder)
        {
            StreamWriter writer = new StreamWriter(dataFileName);
            writer.WriteLine(medarbejder.StringSave());
            writer.Close();
        }

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
            medarbejder = new Medarbejder(a_medarbejder[0], a_medarbejder[1], int.Parse(a_medarbejder[2]), DateTime.Parse(a_medarbejder[3]), DateTime.Parse(a_medarbejder[4]), bool.Parse(a_medarbejder[5]));
            return medarbejder;
        }

        
    }
    class Dagslog
    {

    }
}

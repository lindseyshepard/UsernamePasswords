using System;
using System.Collections.Generic;

namespace PasswordEncryptionAuthentication
{
    class MyUserDictionary
    {


        //use this class to create user information to be stored to RAM
        public void Login()
        {
            Dictionary<string, string> Creds = new Dictionary<string, string>();

            Creds.Add("txt", "notepad.exe");
            Creds.Add("bmp", "paint.exe");
            Creds.Add("dib", "paint.exe");
            Creds.Add("rtf", "wordpad.exe");

            try
            {
                Creds.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }
        }
    }
}



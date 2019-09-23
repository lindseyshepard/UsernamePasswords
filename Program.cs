namespace PasswordEncryptionAuthentication
{
    class Program
    {
        static void Main(string[] args)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Display();
            MyUserDictionary myUserDictionary = new MyUserDictionary();
            myUserDictionary.Login();
            Authenticate authenticate = new Authenticate();
            authenticate.VerifyUser();

            int menuoptions = 3;
            switch (menuoptions)
            {
                case 1:
                    myUserDictionary.Login();
                    break;
                case 2:
                    //here thing;
                    break;
                case 3:
                    //here thing exit method
                    //  Dispose();
                    break;

            }
        }
    }
}

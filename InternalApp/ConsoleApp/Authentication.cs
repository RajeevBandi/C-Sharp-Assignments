using BusinessLayer;
using BusinessModel;

namespace ConsoleApp
{
    /// <summary>
    /// The page is rerouted based on the user's selection, and also takes user input.
    /// </summary>
    public class Authentication
    {
        /// <summary>
        /// This method requests user input, which is necessary for Login Page.
        /// </summary>
        public void Login()
        {

            User usersObj = new User();

            Display.LogMsg(Literals.inputUsername);
            usersObj.Username = Console.ReadLine();

            Display.LogMsg(Literals.inputPassword);
            usersObj.Password = Console.ReadLine();

            BALFactory BALObj = new BALFactory();
            IBAL BALFactoryObj = BALObj.BALObjCreation();

            if (BALFactoryObj.Login(usersObj))
            {
                Display.LogMsg(Literals.loginSuccess);
                string logout = "0";
                while (logout != "3")
                {
                    logout = Console.ReadLine();
                }
                Display.LogMsg(Literals.logoutSuccess);
            }
            else
            {
                Display.LogMsg(Literals.invalidCredentials);
                string forgotPassword = Console.ReadLine();
                if (forgotPassword == "4")
                {
                    if (ForgotPassword())
                    {
                        Display.LogMsg(Literals.passwordUpdated);
                    }
                    else
                    {
                        Display.LogMsg(Literals.passwordUpdateFailed);
                    }
                }
            }

        }

        /// <summary>
        /// This method requests user input, which is necessary for Forgot Password.
        /// </summary>
        /// <returns></returns>
        public bool ForgotPassword()
        {
            User usersObj = new User();

            Display.LogMsg(Literals.inputUsername);
            usersObj.Username = Console.ReadLine();

            Display.LogMsg(Literals.inputNewPassword);
            usersObj.Password = Console.ReadLine();

            BALFactory BALObj = new BALFactory();
            IBAL BALFactoryObj = BALObj.BALObjCreation();

            return BALFactoryObj.ForgotPassword(usersObj);
        }

        /// <summary>
        /// This method requests user input, which is necessary for registration.
        /// </summary>
        /// <returns> The registration status as an integer </returns>
        public void Registration()
        {
            User usersObj = new User();

            Display.LogMsg(Literals.inputUsername);
            usersObj.Username = Console.ReadLine();

            BALFactory BALObj = new BALFactory();
            IBAL BALFactoryObj = BALObj.BALObjCreation();

            Display.LogMsg(Literals.inputPassword);
            usersObj.Password = Console.ReadLine();

            Display.LogMsg(Literals.inputName);
            usersObj.Name = Console.ReadLine();

            Display.LogMsg(Literals.inputPhoneNo);
            usersObj.PhoneNo = Console.ReadLine();

            string registrationStatus = BALFactoryObj.Registration(usersObj);

            while (registrationStatus != Literals.registerSuccessful)
            {
                if (registrationStatus == Literals.invalidUsername)
                {
                    Display.LogMsg(registrationStatus);
                    Display.LogMsg(Literals.inputUsername);
                    usersObj.Username = Console.ReadLine();
                    registrationStatus = BALFactoryObj.Registration(usersObj);
                }
                else if (registrationStatus == Literals.invalidPassword)
                {
                    Display.LogMsg(registrationStatus);
                    Display.LogMsg(Literals.inputPassword);
                    usersObj.Password = Console.ReadLine();
                    registrationStatus = BALFactoryObj.Registration(usersObj);
                }
                else if (registrationStatus == Literals.invalidName)
                {
                    Display.LogMsg(registrationStatus);
                    Display.LogMsg(Literals.inputName);
                    usersObj.Name = Console.ReadLine();
                    registrationStatus = BALFactoryObj.Registration(usersObj);
                }
                else if (registrationStatus == Literals.invalidPhoneNo)
                {
                    Display.LogMsg(registrationStatus);
                    Display.LogMsg(Literals.inputPhoneNo);
                    usersObj.PhoneNo = Console.ReadLine();
                    registrationStatus = BALFactoryObj.Registration(usersObj);
                }
            }

            if (registrationStatus == Literals.registerSuccessful)
            {
                Display.LogMsg(registrationStatus);
            }
        }
    }
}

using BusinessModel;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    /// <summary>
    /// This is the application's landing page.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Depending on the user's choice, the page is redirected.
        /// </summary>
        public static void Main()
        {
            //bool registrationFlag = false;
            Authentication AuthObj = new Authentication();
            while (true)
            {
                Display.LogMsg(Literals.pageInfo);
                string option = Console.ReadLine();
                int value;

                if (Regex.IsMatch(option, "[1-3]"))
                {
                    value = Int32.Parse(option);
                }
                else
                {
                    value = 0;
                }

                switch (value)
                {
                    case (int)Menu.Login:
                        AuthObj.Login();
                        break;
                    case (int)Menu.Register:
                        AuthObj.Registration();
                        break;
                    case (int)Menu.Exit:
                        Environment.Exit(1);
                        break;
                    default:
                        Display.LogMsg(Literals.invalidPage);
                        break;
                }
            }
        }
    }
}

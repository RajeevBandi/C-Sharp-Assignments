using System;

namespace Strings_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            //user input
            Read inputObj = new Read();
            string str1 = inputObj.Input1();
            string str2 = inputObj.Input2();

            //To check wether user input is valied or not 
            Validations CheckObj = new Validations();
            Write writeObj = new Write();

            //If the user input is valid then program continues executing in Helper Method
            if (CheckObj.InputCheck(str1,str2))
            {
                Helper helperObj = new Helper();
                helperObj.HelperMethod(str1, str2);
            }
        }
    }
}

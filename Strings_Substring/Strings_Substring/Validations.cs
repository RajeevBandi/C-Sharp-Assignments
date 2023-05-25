using System;
using MyStringMethods;


namespace Strings_Substring
{
    class Validations
    {
        /// <summary>
        /// Returns True if User inputs are valied else Return false and Print the appropriate message
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public bool InputCheck(string str1, string str2)
        {
            MyStringClass MyStringObj = new MyStringClass();

            int str1Len = MyStringObj.MyStringLength(str1);
            int str2Len = MyStringObj.MyStringLength(str2);

            Write writeObj = new Write();

            if(str1 == string.Empty && str2 == string.Empty)
            {
                writeObj.WrongInput();
                return false;
            }
            else if (str1 == string.Empty && str2 != string.Empty)
            {
                writeObj.WrongInputs1();
                return false;
            }
            else if(str1 != string.Empty && str2 == string.Empty)
            {
                writeObj.WrongInputs2();
                return false;
            }
            else if(str1Len < str2Len)
            {
                writeObj.WrongInputBoth();
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}

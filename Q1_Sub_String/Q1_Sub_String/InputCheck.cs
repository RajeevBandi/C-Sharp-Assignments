using MyStringMethods;


namespace Q1_Sub_String
{
    class InputCheck
    {
        // ' UserInput ' checks if the input is valied or not 
        // if its valied returns true
        // else it returns false
        public bool UserInput(string str1 , string str2)
        {
            MyStringClass MyStringObj = new MyStringClass();

            int str1Len = MyStringObj.MyStringLength(str1);
            int str2Len = MyStringObj.MyStringLength(str2);

            if (str1Len < str2Len)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}

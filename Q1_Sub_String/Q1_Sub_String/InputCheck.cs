using MyStringMethods;


namespace Q1_Sub_String
{
    class InputCheck
    {
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

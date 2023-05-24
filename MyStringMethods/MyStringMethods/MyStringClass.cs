
namespace MyStringMethods
{
    public class MyStringClass
    {
        public int MyStringLength(string str)
        {
            int strLength = 0;
            foreach (char c in str)
            {
                strLength++;
            }
            return strLength;
        }

        public string MySubString(string str, int startIndex, int subStringLen)
        {
            string s = "";
            for (int i = startIndex; i < (startIndex + subStringLen); i++)
            {
                s = s + str[i];
            }
            return s;
        }
    }
}

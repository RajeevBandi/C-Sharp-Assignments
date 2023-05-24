using MyStringMethods;


namespace Q1_Sub_String
{
    public class SubstringClass
    {
        //returns the count of sub strings occured in str1
        public int NoOfSubStringOccured(string str1, string str2)
        {

            MyStringClass MyStringObj = new MyStringClass();

            int str1Len = MyStringObj.MyStringLength(str1);
            int str2Len = MyStringObj.MyStringLength(str2);

            int cnt = 0;

            for (int i = 0; i <= str1Len - str2Len; i++)
            {
                string temp = MyStringObj.MySubString(str1, i, str2Len);
                if (temp == str2)
                {
                    cnt++;
                }

            }
            return cnt;
        }


        // Returns an arrayof substring starting indexes 
        public int[] IndexPosition(int n, string str1, string str2)
        {
            int[] finalIdx = new int[n];

            MyStringClass MyStringObj = new MyStringClass();
            int str1Len = MyStringObj.MyStringLength(str1);
            int str2Len = MyStringObj.MyStringLength(str2);

            int j = 0;

            for (int i = 0; i <= str1Len - str2Len; i++)
            {
                string temp = MyStringObj.MySubString(str1, i, str2Len);
                if (temp == str2)
                {
                    finalIdx[j] = i;
                    j++;
                }

            }
            return finalIdx;
        }
    }
}

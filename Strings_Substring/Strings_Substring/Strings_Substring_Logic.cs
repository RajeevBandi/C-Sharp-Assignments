using System;
using MyStringMethods;

namespace Strings_Substring
{
    /// <summary>
    /// Main Logic to find the substring2 in string1
    /// </summary>
    class Strings_Substring_Logic
    {
        /// <summary>
        /// This method returns the number of occurrences of substring2 in string1.
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="str1Len"></param>
        /// <param name="str2Len"></param>
        /// <returns></returns>
        public int NoOfSubStringOccured(string str1, string str2,int str1Len, int str2Len)
        {

            MyStringClass MyStringObj = new MyStringClass();
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


        /// <summary>
        /// This method returns and array which consists of starting indexes of substring2 in string1
        /// </summary>
        /// <param name="n"></param>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="str1Len"></param>
        /// <param name="str2Len"></param>
        /// <returns></returns>
        public int[] IndexPosition(int n, string str1, string str2,int str1Len, int str2Len)
        {
            int[] finalIdx = new int[n];
            MyStringClass MyStringObj = new MyStringClass();

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

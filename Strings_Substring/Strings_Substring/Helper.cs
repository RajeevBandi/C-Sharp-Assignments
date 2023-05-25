using MyStringMethods;
using System;


namespace Strings_Substring
{
    class Helper
    {
        /// <summary>
        /// Helper method is used to call the Strings_substring_logic class methods and print the appropriate output returned by those methods
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        public void HelperMethod(string str1, string str2)
        {
            MyStringClass MyStringObj = new MyStringClass();
            Write writeObj = new Write();
            int str1Len = MyStringObj.MyStringLength(str1);
            int str2Len = MyStringObj.MyStringLength(str2);
            Strings_Substring_Logic logicObj = new Strings_Substring_Logic();
            int substrincCnt = logicObj.NoOfSubStringOccured(str1, str2,str1Len,str2Len);
            writeObj.PrintInt(substrincCnt);
            int[] IdxPosition = logicObj.IndexPosition(substrincCnt, str1, str2,str1Len,str2Len);
            writeObj.PrintArray(IdxPosition, substrincCnt);
        }
    }
}

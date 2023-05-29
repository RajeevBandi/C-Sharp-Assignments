using System;
using MyStringFunctions;

namespace BCDaddition
{
    /// <summary>
    /// used to do binary or integer conversions 
    /// </summary>
    class Conversions
    {
        /// <summary>
        /// a binary string is converted to its decimal value.
        /// </summary>
        /// <param name="str"></param>
        /// <returns> integer </returns>
        public double BinaryToInt(string str)
        {
            double result = 0;
            MyStringClass strObj = new MyStringClass();
            int strLen = strObj.MyStringLength(str);


            for (int i = strLen - 1, j = 0; i >= 0; i--, j++)
            {
                if (str[i] == '1')
                {
                    result += Math.Pow(2, j);
                }
            }
            return result;
        }


        /// <summary>
        /// used to get a binary string of a specific digit.
        /// </summary>
        /// <param name="c"></param>
        /// <returns>binary string</returns>
        public string getBinary(char c)
        {
            int num = c - '0';
            string str = string.Empty;
            for (int i = 0; num > 0; i++)
            {
                str = str + num % 2;
                num = num / 2;
            }

            MyStringClass strobj = new MyStringClass();
            int strLen = strobj.MyStringLength(str);
            string binaryStr = string.Empty;

            // If the binary string's length is less than 4, then add zeros till its length reaches 4.
            for (int i = 0; i < 4 - strLen; i++)
            {
                str += '0';
            }

            strLen = strobj.MyStringLength(str);

            for (int i = strLen - 1; i >= 0; i--)
            {
                binaryStr = binaryStr + str[i];
            }

            return binaryStr;
        }

    }
}

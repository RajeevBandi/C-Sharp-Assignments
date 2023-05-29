using MyStringFunctions;

namespace BCDaddition
{
    class Additions
    {
        /// <summary>
        /// Performing BCD addition on two Binary strings 
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="tCarry">carry of previous addition </param>
        /// <param name="xCarry">changing the carry based on the current addition</param>
        /// <returns>sum of two binary strings</returns>
        public string BDCAddition(string str1, string str2, int tCarry, out int xCarry)
        {
            // adding two binary strings 
            string result = string.Empty;
            MyStringClass strObj = new MyStringClass();
            int str1Len = strObj.MyStringLength(str1);
            int str2Len = strObj.MyStringLength(str2);
            int i = str1Len - 1;
            int j = str2Len - 1;
            int sum = 0, carry = tCarry;
            string temp = string.Empty;

            while (i >= 0 || j >= 0)
            {
                sum = carry;
                if (i >= 0) { sum += str1[i] - '0'; }
                if (j >= 0) { sum += str2[j] - '0'; }
                temp += (sum % 2);
                carry = sum / 2;
                i--;
                j--;
            }

            for (int k = strObj.MyStringLength(temp) - 1; k >= 0; k--)
            {
                result += temp[k];
            }

            Conversions conversionObj = new Conversions();
            double binaryNum = conversionObj.BinaryToInt(result);

            // if the result of the addition is greater than 9 or it consists any carry then add 6 (i.e.. "0110") to the result.
            string binarySum = string.Empty;
            string binarySumRev = string.Empty;
            if ((carry == 0 && binaryNum > 9) || carry != 0)
            {
                if (carry == 0)
                {
                    carry = 1;
                }
                int resultLen = strObj.MyStringLength(result);
                string six = "0110";
                int k = 3;
                int l = resultLen - 1;
                int s = 0, c = 0;
                while (k >= 0 || l >= 0)
                {
                    s = c;
                    if (k >= 0) { s += six[k] - '0'; }
                    if (l >= 0) { s += result[l] - '0'; }
                    binarySum += s % 2;
                    c = s / 2;
                    k--;
                    l--;
                }

                for (int q = strObj.MyStringLength(binarySum) - 1; q >= 0; q--)
                {
                    binarySumRev += binarySum[q];
                }
            }
            else
            {
                binarySumRev = result;
            }

            xCarry = carry;

            return binarySumRev;

        }
    }
}

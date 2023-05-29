namespace BCDaddition
{
    /// <summary>
    /// used to split a float number to get its integral or fractional parts. 
    /// </summary>
    class GetIntegerOrFractionalPart
    {
        /// <summary>
        /// used to get only the fractional portion of a specified float number.
        /// </summary>
        /// <param name="num"></param>
        /// <returns>only the fractional part</returns>
        public string getFractionalPart(string num)
        {
            int dotCnt = 0;
            string str = string.Empty;
            for (int i = 0; i < num.Length; i++)
            {
                if (dotCnt == 1)
                {
                    str += num[i];
                }
                else if (num[i] == '.')
                {
                    dotCnt++;
                }
            }
            return str;

        }

        /// <summary>
        /// used to get only the integral portion of a specified float number.
        /// </summary>
        /// <param name="num"></param>
        /// <returns>only the integral part</returns>
        public string getIntegerPart(string num)
        {
            string str = string.Empty;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == '.')
                {
                    break;
                }
                else
                {
                    str += num[i];
                }
            }
            return str;
        }

    }
}

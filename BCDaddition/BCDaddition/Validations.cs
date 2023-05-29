namespace BCDaddition
{
    /// <summary>
    /// Used to verify the user inputs
    /// </summary>
    class Validations
    {
        /// <summary>
        /// Is used to verify that the number is displayed in float format.
        /// </summary>
        /// <param name="num"> User input number</param>
        /// <returns> true if number is valid, false if number is invalid </returns>
        public bool CheckInput(string num)
        {
            int dotCnt = 0;

            if (num == "" || num == ".")
            {
                return false;
            }

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == '.' && dotCnt == 1)
                {
                    return false;
                }
                else if ((num[i] < '0' || num[i] > '9') && num[i] != '.')
                {
                    return false;
                }
                else if (num[i] == '.')
                {
                    dotCnt++;
                }
            }

            return true;
        }
    }
}

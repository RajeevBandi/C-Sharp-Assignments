using System;

namespace BusinessLogicLayer
{
    public class EncryptDecrypt
    {
        /// <summary>
        /// Converts the string into secret code that hides the informations true meaning and also converts secret code into original string 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string StringEncryptDecrypt(string str)
        {
            string encryptedStr = string.Empty;
            int key = 7;
            foreach (char c in str)
            {
                encryptedStr += Convert.ToChar(Convert.ToInt32(c) ^ key);
            }
            return encryptedStr;
        }
    }
}

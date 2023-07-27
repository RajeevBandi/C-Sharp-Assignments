using System;

namespace BusinessLogicLayer
{
    public class Encryption
    {
        /// <summary>
        /// Converts the string into secret code that hides the informations true meaning 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string StringEncryption(string str)
        {
            string encryptedStr = string.Empty;
            int key = 7;
            foreach (char c in str)
            {
                encryptedStr += Convert.ToString(Convert.ToInt32(c) ^ key);
            }
            return encryptedStr;
        }
    }
}

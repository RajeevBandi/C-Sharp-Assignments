using System;

namespace Strings_Substring
{
    /// <summary>
    /// To perform Read operation
    /// </summary>
    class Read
    {
        /// <summary>
        /// String 1 is collected from the user's input 
        /// </summary>
        /// <returns></returns>
        public string Input1()
        {
            Console.Write("Enter String 1: ");
            string str1 = Console.ReadLine();
            return str1;
        }

        /// <summary>
        /// String 2 is collected from the user's input 
        /// </summary>
        /// <returns></returns>
        public string Input2()
        {
            Console.Write("Enter String 2: ");
            string str2 = Console.ReadLine();
            return str2;
        }

    }
}

using System;

namespace Max4DigitProduct
{
    class Read
    {
        /// <summary>
        /// Used to take user Input Number
        /// </summary>
        /// <returns>
        /// The string form of a number  
        /// </returns>
        public string InputNum()
        {
            Console.Write("Enter the Input number : ");
            string num = Console.ReadLine();
            return num;
        }
    }
}
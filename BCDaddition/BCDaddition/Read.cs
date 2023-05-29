using System;

namespace BCDaddition
{
    class Read
    {
        /// <summary>
        /// Is used to read Input number 1 from the user
        /// </summary>
        /// <returns>float number as string</returns>
        public string Input1()
        {
            Console.Write("Enter Number 1 : ");
            string num1 = Console.ReadLine();
            return num1;
        }

        /// <summary>
        /// Is used to read Input number 2 from the user
        /// </summary>
        /// <returns> float number as string </returns>
        public string Input2()
        {
            Console.Write("Enter Number 2 : ");
            string num2 = Console.ReadLine();
            return num2;
        }
    }
}

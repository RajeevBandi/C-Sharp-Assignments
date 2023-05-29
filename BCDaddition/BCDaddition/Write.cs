using System;

namespace BCDaddition
{
    class Write
    {
        /// <summary>
        /// used for printing Incorrect user input 1
        /// </summary>
        public void InvalidInput1()
        {
            Console.WriteLine("Invalid Number 1");
        }

        /// <summary>
        /// used for printing Incorrect user input 2
        /// </summary>
        public void InvalidInput2()
        {
            Console.WriteLine("Invalid Number 2");
        }


        /// <summary>
        /// To display float numbers and their BCD representation. 
        /// </summary>
        /// <param name="str"> float number </param>
        /// <param name="strBinary"> BCD representation</param>
        public void FloatNumberInBinary(string str, string strBinary)
        {
            Console.WriteLine("Float Number : " + str + " in binary : " + strBinary);
        }


        /// <summary>
        /// used to display the final Binary sum 
        /// </summary>
        /// <param name="str"> sum in BCD </param>
        public void SumBinaryAddition(string str)
        {
            Console.WriteLine("Sum in Binary : " + str);
        }
    }
}

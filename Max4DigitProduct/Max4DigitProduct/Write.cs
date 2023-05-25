using System;

namespace Max4DigitProduct
{

    class Write
    {
        /// <summary>
        /// This Method is used to print 'invalid input' when the input consists less than 4 digits
        /// </summary>
        public void WrongInput()
        {
            Console.WriteLine("Invalid Input : Input number consists of less than 4 digits ");
        }

        /// <summary>
        /// This Method is used to print 'invalid input' when input contains characters other than those necessary    
        /// </summary>
        public void InputConsistsAlpha()
        {
            Console.WriteLine("Invalid Input : Other characters are included in the input number.");
        }

        /// <summary>
        /// This Method is used to print the output as product elements along with the product result.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        public void printResult(int[] arr, int n)
        {
            for (int i = 1; i < n; i++)
            {
                Console.Write(arr[i]);
                if (i < n - 1)
                {
                    Console.Write(" * ");
                }
            }
            Console.Write(" = " + arr[0] + "\n");
        }
    }
}
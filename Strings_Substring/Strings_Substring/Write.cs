using System;

namespace Strings_Substring
{
    /// <summary>
    /// Used to print the output
    /// </summary>
    class Write
    {
        /// <summary>
        /// This method is used when string 1 length is less then string 2 length
        /// </summary>
        public void WrongInputBoth()
        {
            Console.WriteLine("String 1 is lesser than String 2 are Invalid Input");
        }

        /// <summary>
        /// This method is used if string1 is an empty string.
        /// </summary>
        public void WrongInputs1()
        {
            Console.WriteLine("String 1 is Invalied Input..");
        }

        /// <summary>
        /// This method is used if string2 is an empty string.
        /// </summary>
        public void WrongInputs2()
        {
            Console.WriteLine("String 2 is Invalied Input");
        }

        /// <summary>
        /// This method is used if string1 and string2 are empty strings.
        /// </summary>
        public void WrongInput()
        {
            Console.WriteLine("String 1 and String 2 are Invalid Input ");
        }

        /// <summary>
        /// This method is used to print any integer
        /// </summary>
        /// <param name="x"></param>
        public void PrintInt(int x)
        {
            Console.WriteLine("No Of Sub String Occured : " + x);
        }

        /// <summary>
        /// This method is used to print an array of size n
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        public void PrintArray(int[] arr,int n)
        {

            Console.Write("Index Position : ");
            for (int i=0;i<n;i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
    }
}

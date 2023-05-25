using System;

namespace Max4DigitProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Input
            Read readObj = new Read();
            string num = readObj.InputNum();

            //To Check wether the user Input is valid or invalid 
            Validations InputObj = new Validations();

            if (InputObj.CheckInputNum(num))
            {
                Max4DigitProjectLogic logicObj = new Max4DigitProjectLogic();
                Write writeObj = new Write();
                writeObj.printResult(logicObj.GreatestProduct(num), 5);
            }
        }
    }
}

using MyStringMethods;

namespace Max4DigitProduct
{
    class Validations
    {
        /// <summary>
        /// this method is used to check wether the input is valid, returns true else, it calls for the incorrect input's cause and returns false.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool CheckInputNum(string num)
        {
            MyStringClass stringObj = new MyStringClass();
            int numLen = stringObj.MyStringLength(num);

            int flag = 0;
            for (int i = 0; i < numLen; i++)
            {
                if (num[i] - '0' < 0 || num[i] - '0' > 9)
                {
                    flag++;
                    break;
                }
            }

            Write writeObj = new Write();
            if (numLen < 4)
            {
                writeObj.WrongInput();
                return false;
            }
            else if (flag == 1)
            {
                writeObj.InputConsistsAlpha();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

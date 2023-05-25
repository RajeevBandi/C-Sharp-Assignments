using MyStringMethods;

namespace Max4DigitProduct
{
    class Max4DigitProjectLogic
    {
        /// <summary>
        /// This method is used to find the max of 4 product elements 
        /// </summary>
        /// <param name="num"></param>
        /// <returns>array which consists of max 4 product elements </returns>
        public int[] GreatestProduct(string num)
        {
            // To store the result along with 4 product elements 
            int[] result = new int[5];
            int productElement1, productElement2, productElement3, productElement4;

            MyStringClass stringObj = new MyStringClass();
            int numLen = stringObj.MyStringLength(num);

            for (int i = 0; i < numLen - 3; i++)
            {
                productElement1 = num[i] - '0';
                productElement2 = num[i + 1] - '0';
                productElement3 = num[i + 2] - '0';
                productElement4 = num[i + 3] - '0';

                if ((productElement1 * productElement2 * productElement3 * productElement4) > result[0])
                {
                    result[0] = productElement1 * productElement2 * productElement3 * productElement4;
                    result[1] = productElement1;
                    result[2] = productElement2;
                    result[3] = productElement3;
                    result[4] = productElement4;
                }
            }
            return result;
        }
    }
}
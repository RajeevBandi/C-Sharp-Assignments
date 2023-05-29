using MyStringFunctions;

namespace BCDaddition
{
    /// <summary>
    /// Once the user inputs are confirmed to be valid, this class represents the program's actual logic. 
    /// </summary>
    class Logic
    {
        /// <summary>
        /// used to conduct addition by converting float integers to binary, and also to convert that binary sum into float
        /// </summary>
        /// <param name="str1"> float number 1 in string </param>
        /// <param name="str2"> float number 2 in string </param>
        public void FloatAdditionLogic(string str1, string str2)
        {
            // getting the fractional part of two numbers.
            GetIntegerOrFractionalPart fractionOrIntObj = new GetIntegerOrFractionalPart();
            string str1Fractional = fractionOrIntObj.getFractionalPart(str1);
            string str2Fractional = fractionOrIntObj.getFractionalPart(str2);

            // lengths of the fractional part.
            MyStringClass strObj = new MyStringClass();
            int str1FractionLen = strObj.MyStringLength(str1Fractional);
            int str2FractionLen = strObj.MyStringLength(str2Fractional);

            // converting two numbers' fractional component lengths to the same by adding zero's.
            if (str1FractionLen > str2FractionLen)
            {
                int diff = str1FractionLen - str2FractionLen;
                for (int i = 0; i < diff; i++)
                {
                    str2Fractional = str2Fractional + 0;
                }
            }
            else if (str1FractionLen < str2FractionLen)
            {
                int diff = str2FractionLen - str1FractionLen;
                for (int i = 0; i < diff; i++)
                {
                    str1Fractional = str1Fractional + 0;
                }
            }

            // converting the fractional part to BCD and performing addition 
            int xCarry = 0;
            Conversions convertionObj = new Conversions();
            Additions additionObj = new Additions();

            str1FractionLen = strObj.MyStringLength(str1Fractional);

            string FractionalBinarySum = string.Empty;
            string totalFractional1Binary = string.Empty;
            string totalFractional2Binary = string.Empty;

            for (int i = str1FractionLen - 1; i >= 0; i--)
            {
                string fraction1Binary = convertionObj.getBinary(str1Fractional[i]);
                string fraction2Binary = convertionObj.getBinary(str2Fractional[i]);

                totalFractional1Binary = fraction1Binary + totalFractional1Binary;
                totalFractional2Binary = fraction2Binary + totalFractional2Binary;

                string stringTemp = additionObj.BDCAddition(fraction1Binary, fraction2Binary, xCarry, out xCarry);

                FractionalBinarySum = stringTemp + FractionalBinarySum;
            }



            // getting the integral part of two numbers

            string str1Integer = fractionOrIntObj.getIntegerPart(str1);
            string str2Integer = fractionOrIntObj.getIntegerPart(str2);

            // lengths of the integral part.
            int str1IntegerLen = strObj.MyStringLength(str1Integer);
            int str2IntegerLen = strObj.MyStringLength(str2Integer);

            //converting two numbers' integral component lengths to the same by adding zero's.
            if (str1IntegerLen > str2IntegerLen)
            {
                int diff = str1IntegerLen - str2IntegerLen;

                for (int i = 0; i < diff; i++)
                {
                    str2Integer = 0 + str2Integer;
                }

                str2Integer = string.Empty;
            }
            else if (str1IntegerLen < str2IntegerLen)
            {
                int diff = str2IntegerLen - str1IntegerLen;

                for (int i = 0; i < diff; i++)
                {
                    str1Integer = 0 + str1Integer;
                }
            }

            // converting the integral part to BCD and performing addition

            string IntegerBinarySum = string.Empty;
            string totalInteger1Binary = string.Empty;
            string totalInteger2Binary = string.Empty;

            str1IntegerLen = strObj.MyStringLength(str1Integer);

            for (int i = str1IntegerLen - 1; i >= 0; i--)
            {
                string Integer1Binary = convertionObj.getBinary(str1Integer[i]);
                string Integer2Binary = convertionObj.getBinary(str2Integer[i]);

                totalInteger1Binary = Integer1Binary + totalInteger1Binary;
                totalInteger2Binary = Integer2Binary + totalInteger2Binary;

                string stringTemp = additionObj.BDCAddition(Integer1Binary, Integer2Binary, xCarry, out xCarry);
                IntegerBinarySum = stringTemp + IntegerBinarySum;
            }

            if (xCarry == 1)
            {
                IntegerBinarySum = "0001" + IntegerBinarySum;
            }


            // combining the integral and fractional BCD
            string float1InBCD = string.Empty;
            string float2InBCD = string.Empty;
            string floatSumInBCD = string.Empty;

            
            if(totalFractional1Binary == string.Empty)
            {
                float1InBCD = totalInteger1Binary + ".0";
            }
            else if(totalInteger1Binary == string.Empty)
            {
                float1InBCD = "0." + totalFractional1Binary;
            }
            else
            {
                float1InBCD = totalInteger1Binary + "." + totalFractional1Binary;
            }


            
            if (totalFractional2Binary == string.Empty)
            {
                float2InBCD = totalInteger2Binary + ".0";
            }
            else if(totalInteger2Binary==string.Empty)
            {
                float2InBCD = "0." + totalFractional2Binary;
            }
            else
            {
                float2InBCD = totalInteger2Binary + "." + totalFractional2Binary;
            }


            
            if(FractionalBinarySum == string.Empty )
            {
                floatSumInBCD = IntegerBinarySum + ".0";
            }
            else if(IntegerBinarySum== string.Empty)
            {
                floatSumInBCD = "0." + FractionalBinarySum;
            }
            else
            {
                floatSumInBCD = IntegerBinarySum + "." + FractionalBinarySum;
            }


            // logic to convert sum in binary to decimal
            string floatSumInDecimal = string.Empty;
            int IntegerBinarySumLen = strObj.MyStringLength(IntegerBinarySum);
            string temp = string.Empty;
            for (int j = 0, i = 0; i < IntegerBinarySumLen; i++, j++)
            {
                temp = temp + IntegerBinarySum[i];
                if (j == 3)
                {
                    floatSumInDecimal += convertionObj.BinaryToInt(temp);
                    temp = string.Empty;
                    j = -1;
                }

            }

            floatSumInDecimal += '.';

            int FractionalBinarySumLen = strObj.MyStringLength(FractionalBinarySum);
            temp = string.Empty;

            for (int j = 0, i = 0; i < FractionalBinarySumLen; i++, j++)
            {
                temp = temp + FractionalBinarySum[i];
                if (j == 3)
                {
                    floatSumInDecimal += convertionObj.BinaryToInt(temp);
                    temp = string.Empty;
                    j = -1;
                }

            }

            // method calls to print the result 
            Write writeObj = new Write();
            writeObj.FloatNumberInBinary(str1, float1InBCD);
            writeObj.FloatNumberInBinary(str2, float2InBCD);
            writeObj.SumBinaryAddition(floatSumInBCD);
            writeObj.FloatNumberInBinary(floatSumInDecimal, floatSumInBCD);
        }
    }
}

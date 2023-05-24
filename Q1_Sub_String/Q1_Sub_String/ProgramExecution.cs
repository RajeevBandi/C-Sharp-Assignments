using System;


namespace Q1_Sub_String
{
    class ProgramExecution
    {
        public void StartExecution(string str1, string str2)
        {

            InputCheck input1 = new InputCheck();
            if (input1.UserInput(str1, str2))
            {
                SubstringClass demo = new SubstringClass();

                int SubStringCount = demo.NoOfSubStringOccured(str1, str2);

                Console.WriteLine("No Of Sub String Occured : " + SubStringCount);

                int[] IdxPosition = demo.IndexPosition(SubStringCount, str1, str2);

                Console.Write("Index Position : ");
                for (int i = 0; i < SubStringCount; i++)
                {
                    Console.Write(IdxPosition[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}

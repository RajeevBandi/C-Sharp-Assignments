using System;


namespace Q1_Sub_String
{
    class ProgramExecution
    {
        // performs the operation if the input is valied
        public void StartExecution(string str1, string str2)
        {
            // UserInput method returns true or false (i.e.. wether the input is true or false)
            InputCheck input1 = new InputCheck();
            if (input1.UserInput(str1, str2))
            {
                // StringClass consists of two methods 
                // 1.NoOfSubStringOccured - returns int
                // 2.IndexPosition - returns array[]
                SubstringClass obj = new SubstringClass();

                int SubStringCount = obj.NoOfSubStringOccured(str1, str2);

                Console.WriteLine("No Of Sub String Occured : " + SubStringCount);

                int[] IdxPosition = obj.IndexPosition(SubStringCount, str1, str2);

                Console.Write("Index Position : ");
                for (int i = 0; i < SubStringCount; i++)
                {
                    Console.Write(IdxPosition[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalied input");
            }
        }
    }
}

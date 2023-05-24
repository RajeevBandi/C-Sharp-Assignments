using System;



namespace Q1_Sub_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Valied input ( ie.. string 1 length > string 2 length)");
            Console.Write("Enter string 1 : ");
            string str1 = Console.ReadLine();
            Console.Write("Enter string 2 : ");
            string str2 = Console.ReadLine();

            ProgramExecution testCase1 = new ProgramExecution();
            testCase1.StartExecution(str1, str2);
        }
    }
}

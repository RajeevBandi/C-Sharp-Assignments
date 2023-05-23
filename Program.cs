using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQ1
{
    public class SubstringClass
    {

        int noOfTimesOccured = 0;
        string s1, s2, temp;
        public SubstringClass(string s1, string s2)
        {
            this.s1 = s1;
            this.s2 = s2;
            for (int i = 0; i < s1.Length - s2.Length; i++)
            {
                temp = (s1.Substring(i, s2.Length));
                if (temp == s2)
                {
                    noOfTimesOccured += 1;
                }
            }
        }

        public void helper()
        {
            Console.WriteLine("No Of Times occured = " + noOfTimesOccured);
            Console.Write("Index Position : ");
            for (int i = 0; i < s1.Length - s2.Length; i++)
            {
                temp = (s1.Substring(i, s2.Length));
                if (temp == s2)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SubstringClass obj1 = new SubstringClass("abcabc", "ab");
            obj1.helper();
        }
    }
}

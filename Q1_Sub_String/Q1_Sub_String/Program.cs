using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Sub_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubstringClass obj1 = new SubstringClass("abcabcabc", "ab");
            obj1.helper();
        }
    }
}

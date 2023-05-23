using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_Greatest_Product
{
    public class GreatestProduch
    {
        string s;
        int a, b, c, d;
        int ans = 0;
        public GreatestProduch(string s)
        {
            this.s = s; 
        }

        public void helper()
        {
            for(int i=0;i<s.Length-3;i++)
            {
                int ta = s[i] - '0';
                int tb = s[i + 1] - '0';
                int tc = s[i + 2] -'0';
                int td = s[i + 3] - '0';

                if ((ta * tb * tc * td) > ans)
                {
                    ans = ta * tb * tc * td;
                    a = ta;
                    b = tb;
                    c = tc;
                    d = td;
                }
            }
            Console.WriteLine(a + "*" + b + "*" + c + "*" + d + "=" + ans);
        }
    }
}

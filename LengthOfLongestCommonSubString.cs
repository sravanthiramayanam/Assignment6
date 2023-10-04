using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class LengthOfLongestCommonSubString
    {
        static int LCSubStr(string X, string Y, int m, int n)
        {

            int[,] LCStuff = new int[m + 1, n + 1];

            int result = 0;

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        LCStuff[i, j] = 0;
                    else if (X[i - 1] == Y[j - 1])
                    {
                        LCStuff[i, j]
                            = LCStuff[i - 1, j - 1] + 1;

                        result
                            = Math.Max(result, LCStuff[i, j]);
                    }
                    else
                        LCStuff[i, j] = 0;
                }
            }

            return result;
        }

        //public static void Main()
        //{
        //    String X = "abcdxyz";
        //    String Y = "xyzabcd";

        //    int m = X.Length;
        //    int n = Y.Length;

        //    Console.Write("Length of Longest Common"
        //                + " Substring is "
        //                + LCSubStr(X, Y, m, n));
        //}
    }
}

    


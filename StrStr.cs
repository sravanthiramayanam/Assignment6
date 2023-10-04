using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment6
{
    class StrStr
    {
        public static int strstr(String X, String needle)
        {
            if (needle == null || needle.Length == 0)
            {
                return 0;
            }

            if (X == null || needle.Length > X.Length)
            {
                return -1;
            }
            int[] lps = new int[needle.Length];
            int i = 1;
            int prevLPS = 0;
            while (i < needle.Length)
            {
                if (needle[i] == needle[prevLPS])
                {
                    lps[i] = prevLPS + 1;
                    prevLPS++;
                    i++;
                }
                else if (prevLPS == 0)
                {
                    lps[i] = 0;
                    i++;
                }
                else
                {
                    prevLPS = lps[prevLPS - 1];
                }

            }

            i= 0;
            int j= 0;

            while (i < X.Length)
            {
                if (X[i] == needle[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    if (j == 0)
                        i++;
                    else
                        j = lps[j - 1];
                }

                if (j == needle.Length)
                    return i - j;
            }

            return -1;
        }

        public static void Main(String[] args)
        {
            String X = "aababcaab";
            String needle = "abca";

            Console.WriteLine("The index of the first occurrence of needle in X is "
                            + strstr(X, needle));
        }
    }
}

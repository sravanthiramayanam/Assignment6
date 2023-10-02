using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class LongestPalindromicSubstring
    {
        static void longestPalSubstr(String s)
        {
            int n = s.Length;
            int start = 0, pLength = 1;
            int low, hi;

            // Traverse the input string
            for (int i = 0; i < n; i++)
            {

                // Find longest palindromic substring of even size
                low = i ; 
                hi = i+1;

                // Expand substring while it is palindrome and in bounds
                while (low >= 0 && hi < n && s[low] == s[hi])
                {

                    // Update maximum length and starting index
                    if (hi - low + 1 > pLength)
                    {
                        start = low;
                        pLength = hi - low + 1;
                    }
                    low--;
                    hi++;
                }

                // Find longest palindromic substring of odd size
                low = i ;
                hi = i + 2;

                // Expand substring while it is palindrome and in bounds
                while (low >= 0 && hi < n && s[low] == s[hi])
                {

                    // Update maximum length and starting index
                    if (hi - low + 1 > pLength)
                    {
                        start = low;
                        pLength = hi - low + 1;
                    }
                    low--;
                    hi++;
                }
            }

            Console.WriteLine("Longest palindrome substring is: ");
            Console.WriteLine(s.Substring(start,  pLength));

        }

        //public static void Main(String[] args)
        //{
        //    String s = "babad";
        //    longestPalSubstr(s);
        //}
    }

}


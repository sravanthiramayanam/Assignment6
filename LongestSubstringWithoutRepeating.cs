using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment6
{
    class LongestSubstringWithoutRepeating
    {
        public static int longestUniqueSubsttr(String str)
        {
            var test = "";

            var maxLength = -1;


            if (str.Length == 0)
            {
                return 0;
            }
            else
            if (str.Length == 1)
            {
                return 1;
            }
            foreach (char c in str.ToCharArray())
            {
                var current = c + "";

                if (test.Contains(current))
                {
                    test = test.Substring(test.IndexOf(current) + 1);
                }
                test = test + c;
                maxLength = Math.Max(test.Length, maxLength);
            }
            return maxLength;
        }

        //public static void Main(String[] args)
        //{
        //    var str = "abca";
        //    Console.WriteLine("The input string is " + str);
        //    var len = longestUniqueSubsttr(str);
        //    Console.WriteLine("The length of the longest " + "non-repeating character " + "substring is " + len.ToString());
        //}

    }
}

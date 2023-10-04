using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment6
{
    internal class ConvertRomanToInteger
    {
        static Dictionary<char, int> roman = new Dictionary<char, int>();

        public static int romanToInt(String s)
        {
            int sum = 0;
            int n = s.Length;

            for (int i = 0; i < n; i++)
            {

                if (i != n - 1 && roman[s[i]] < roman[s[i + 1]])
                {
                    sum += roman[s[i + 1]] - roman[s[i]];
                    i++;
                }
                else
                {
                    sum += roman[s[i]];
                }
            }
            return sum;
        }

        public static void Main(String[] args)
        {

            roman['I'] = 1;
            roman['V'] = 5;
            roman['X'] = 10;
            roman['L'] = 50;
            roman['C'] = 100;
            roman['D'] = 500;
            roman['M'] = 1000;
            String input = "IV";

            Console.Write("int form of Roman Numeral is " + romanToInt(input));
        }
    }
}

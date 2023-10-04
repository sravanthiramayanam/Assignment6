using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longestcommonprefixusing_binary_search
{
    internal class LongestCommonPrefix_BinarySearch
    {

        static int findMinLength(string[] arr, int n)
        {
            int min = int.MaxValue;
            for (int i = 0; i <= (n - 1); i++)
            {
                if (arr[i].Length < min)
                {
                    min = arr[i].Length;
                }
            }
            return min;
        }

        static bool allContainsPrefix(string[] arr, int n,
                                      string str, int start,
                                      int end)
        {
            for (int i = 0; i <= (n - 1); i++)
            {
                string arr_i = arr[i];

                for (int j = start; j <= end; j++)
                    if (arr_i[j] != str[j])
                        return false;
            }
            return true;
        }

        static string commonPrefix(string[] arr, int n)
        {
            int index = findMinLength(arr, n);
            string prefix = "";
            int low = 0, high = index;
            while (low <= high)
            {

                int mid = low + (high - low) / 2;

                if (allContainsPrefix(arr, n, arr[0], low,
                                      mid))
                {
                    prefix = prefix + arr[0].Substring(low, mid + 1);
                    low = mid + 1;
                }
                else 
                {
                    high = mid - 1;
                }
            }

            return prefix;
        }

        //public static void Main()
        //{
        //    string[] arr = { "apple","ape","april"};
        //    int n = arr.Length;

        //    string ans = commonPrefix(arr, n);

        //    if (ans.Length > 0)
        //        Console.WriteLine("The longest common"
        //                          + " prefix is - " + ans);
        //    else
        //        Console.WriteLine("There is no common"
        //                          + " prefix");
        //}
    }
}

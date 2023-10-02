using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class RotatingStringBy2Places
    {
        public static bool IsRotated(string str1, string str2)
        {
            int n = str1.Length;
            bool clockwise = true, anticlockwise = true;

            // clockwise direction check
            for (int i = 0; i < n; i++)
            {
                if (str1[i] != str2[(i + 2) % n])
                {
                    clockwise = false; // not rotated clockwise
                    break;
                }
            }

            // anticlockwise direction check
            for (int i = 0; i < n; i++)
            {
                if (str1[(i + 2) % n] != str2[i])
                {
                    anticlockwise = false; // not rotated anticlockwise
                    break;
                }
            }

            return clockwise || anticlockwise; // if any of both is true, return true
        }

        public static void Main()
        {
            string str1 = "amazon";
            string str2 = "azonam";

            Console.WriteLine(IsRotated(str1, str2) ? "Yes" : "No");
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAdjacentDuplicates
{
    internal class RemoveAdjacentDuplicates
    {
        public static String RemoveAdjacentDupe(String str)
        {
            Stack<char> S = new Stack<char>();
            String returnStr = "";

            int i = 0;
            //pop if same character in the peak otherwise push char to stack
            while (i < str.Length)
            {

                if (S.Count != 0 && S.Peek() == str[i])
                {
                    while (i < str.Length && S.Peek() == str[i])
                    {
                        i++;
                    }
                    S.Pop();
                }
                if(i<str.Length)
                {
                    S.Push(str[i]);
                    i++;
                }
            }
            //creating string from stack
            while (S.Count != 0)
            {
                returnStr = returnStr + S.Pop();
            }
            //reversing string
            returnStr = new string(returnStr.Reverse().ToArray());
            //if string is same as input string, return
            if (str == returnStr)
                return str;
            //otherwise call recursively to remove any more dupes
            else return RemoveAdjacentDupe(returnStr);
        }


        //static public void Main()
        //{
        //    String NoDupeStr = RemoveAdjacentDupe("azxxzy");
        //    Console.WriteLine(NoDupeStr);
        //}
    }
}

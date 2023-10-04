using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignURLShortner
{
    class URLShortner
    {
        // Function to generate a short url from integer ID
        static String idToShortURL(int n)
        {
            char[] map = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();

            String shorturl = "";

            // Convert given integer id to a base 62 number
            while (n > 0)
            {
                shorturl = (map[n % 62]) + shorturl;
                n = n / 62;
            }

            return shorturl; 
        }

        // Function to get integer ID back from a short url
        static int shortURLtoID(String shortURL)
        {
            int id = 0;
            for (int i = 0; i < shortURL.Length; i++)
            {
                char[] map = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
                id = id * 62 + Array.IndexOf(map, shortURL[i]);
            }
            return id;
        }

        //public static void Main(String[] args)
        //{
        //    int n = 12345;
        //    String shorturl = idToShortURL(n);
        //    Console.WriteLine("Generated short url is " + shorturl);
        //    Console.WriteLine("Id from url is " +
        //                        shortURLtoID(shorturl));
        //}
    }
}


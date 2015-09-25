using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
 
    public static class Solution
    {
        // you can also use other imports, for example:
        // using System.Collections.Generic;

        // you can use Console.WriteLine for debugging purposes, e.g.
        // Console.WriteLine("this is a debug message");

        public int solution(int A, int B)
        {
            // write your code in C# 5.0 with .NET 4.5 (Mono)
            var arr1 = A.ToString().ToCharArray();
            var arr2 = B.ToString().ToCharArray();
            string final = "";

            var len1 = arr1.Length;
            var len2 = arr2.Length;

            var indexer = (len1 > len2) ? len2 : len1;

            for (int i = 0; i < indexer; i++)
            {
               final = final+arr1[i]+arr2[i];
            }

            if (len2 > len1)
                final = final + B.ToString().Substring(indexer, len2-indexer);
           
            if(len1 > len2)
                final = final + A.ToString().Substring(indexer, len1-indexer);


            int res = Convert.ToInt32(final);

            return (res > 100000000) ? -1 : res;

       }


        public static void Main()
        {
            int s = solution(12, 12456);
        }
    }
}
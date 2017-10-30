using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class BigComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x.Length == y.Length)
            {
                int length = x.Length;
                for (int i = 0; i < length; i++)
                {

                    if (x[i] > y[i]) return 1;
                    else if (x[i] < y[i]) return -1;
                }
                return 0;
            }
            else if (x.Length > y.Length) return 1;
            else return -1;
        }
    }
    class Solution
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] unsorted = new string[n];
            for (int unsorted_i = 0; unsorted_i < n; unsorted_i++)
            {
                unsorted[unsorted_i] = Console.ReadLine();
            }
            // your code goes here
            Array.Sort(unsorted, new BigComparer());
            for (int i = 0; i < n; i++) Console.WriteLine(unsorted[i]);
        }
    }
}

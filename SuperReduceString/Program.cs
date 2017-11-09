using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperReducedString
{
    class Program
    {
        static string super_reduced_string(string s)
        {
            int n = s.Length;

            for (int i = 0; i <= n - 1; i++)
            {
                if (i + 2 > n)
                    break;

                if (s.Substring(i, 1) == s.Substring(i + 1, 1))
                {
                    s = s.Remove(i, 2);
                    i = -1;
                    n = s.Length;
                }
            }

            if (s.Length == 0)
                return "Empty String";
            else
                return s;
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            string result = super_reduced_string(s);
            Console.WriteLine(result);
        }
    }
}

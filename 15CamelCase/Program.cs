using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solution 1
            string s = Console.ReadLine();
            int n = s.Length;
            int total = 0;

            for (int i = 0; i <= n - 1; i++)
            {
                char character = Convert.ToChar(s.Substring(i, 1));
                if (Char.IsUpper(character))
                {
                    string word = s.Substring(0, i);
                    s = s.Remove(0, i);

                    n = s.Length;
                    i = 0;
                    total++;
                }
            }

            if (s.Length > 0)
                total++;

            //Solution 2
            Console.WriteLine(s.Count(char.IsUpper)+1);
                        
            Console.WriteLine(total);
        }
    }
}

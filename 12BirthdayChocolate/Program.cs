using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12BirthdayChocolate
{
    class Program
    {
        static int solveLinq(int n, int[] s, int d, int m)
        {
            int total = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                if(s.Skip(i).Take(m).Sum() == d) 
                    total++;
            }
            return total;
        }

        static int solve(int n, int[] s, int d, int m)
        {
            int total = 0;
            for (int i=0; i <= n-1; i++)
            {
                int sequence = 0;
                for (int j = 0; j <= m-1; j++)
                {
                    if (i + j >= n)
                        break;
                    sequence += s[i+j];
                }
                if (sequence == d)
                    total++;
            }
            return total;
        }
        //Sample Input
        //5
        //1 2 1 3 2
        //3 2
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            string[] tokens_d = Console.ReadLine().Split(' ');
            int d = Convert.ToInt32(tokens_d[0]);
            int m = Convert.ToInt32(tokens_d[1]);
            int result = solveLinq(n, s, d, m);
            Console.WriteLine(result);
        }
    }
}

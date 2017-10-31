using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09BetweenTwoSets
{
    class Program
    {
        static int getTotalX(int[] a, int[] b)
        {
            int total = 0;

            int firstNum = a[a.Length - 1];
            int lastNum = b[0];

            for (int num = firstNum; num <= lastNum; num++)
            {
                bool match = true;

                for (int ai = 0; ai <= a.Length - 1; ai++)
                {
                    if (num % a[ai] != 0)
                    {
                        match = false;
                        break;
                    }
                }

                for (int bi = 0; bi <= b.Length - 1; bi++)
                {
                    if (b[bi] % num != 0)
                    {
                        match = false;
                        break;
                    }
                }

                if (match == true)
                    total++;
            }

            return total;
        }

        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, Int32.Parse);
            int total = getTotalX(a, b);
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}

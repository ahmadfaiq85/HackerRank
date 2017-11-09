using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperReducedString
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            int sum1 = 0;

            for (int i = 0; i <= n - 1; i++)
            {
                sum1 += a[i][i];
            }

            int sum2 = 0;
            int j = n - 1;
            for (int i = 0; i <= n - 1; i++)
            {
                sum2 += a[i][j];
                j--;
            } 
            Console.WriteLine(Math.Abs(sum1 + sum2)); 
        }


    }
}


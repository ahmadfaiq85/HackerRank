using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonAppetit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(s[0]);
            int k = Convert.ToInt32(s[1]);

            string[] costs_temp = Console.ReadLine().Split(' ');
            int[] costs = Array.ConvertAll(costs_temp, Int32.Parse);

            int share = Convert.ToInt32(Console.ReadLine());

            int total = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                if (i != k)
                    total += costs[i];
            }

            if ((total / 2) == share)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(share - (total / 2));
        }
    }
}

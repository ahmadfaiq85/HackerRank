using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Kangaroo
{
    class Program
    {
        //Sample Input
        //0 3 4 2
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int x1CurrentPosition = x1;
            int x2CurrentPosition = x2;


            for (int i=0; i<=10000;i++)
            {
                x1CurrentPosition += v1;
                x2CurrentPosition += v2;

                if (x1CurrentPosition == x2CurrentPosition)
                    return "YES";
            }

            return "NO";
        }

        static void Main(String[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);
            string result = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }
    }
}

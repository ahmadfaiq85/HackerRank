using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sample Input
            //7 11
            //5 15
            //3 2
            //-2 2 1
            //5 -6

            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] apple_temp = Console.ReadLine().Split(' ');
            int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
            string[] orange_temp = Console.ReadLine().Split(' ');
            int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);

            int appleCount = 0;
            int orangeCount = 0;

            for (int i = 0; i <= apple.Length - 1; i++)
            {
                int applePosition = apple[i] + a;
                if (applePosition >= s && applePosition <= t)
                    appleCount++;
            }

            for (int j = 0; j <= orange.Length - 1; j++)
            {
                int orangePosition = orange[j] + b;
                if (orangePosition >= s && orangePosition <= t)
                    orangeCount++;
            }

            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
            Console.ReadLine();
        }
    }
}

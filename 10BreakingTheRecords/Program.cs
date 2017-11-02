using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10BreakingTheRecords
{
    class Program
    {
        static int[] getRecord(int[] s)
        {
            int highScore = s[0];
            int lowScore = s[0];

            int highScoreCount = 0;
            int lowScoreCount = 0;

            int[] result = new int[2];

            for (int i = 1; i <= s.Length - 1; i++)
            {
                if (s[i] > highScore)
                {
                    highScore = s[i];
                    highScoreCount++;
                }

                if (s[i] < lowScore)
                {
                    lowScore = s[i];
                    lowScoreCount++;
                }
            }

            result[0] = highScoreCount;
            result[1] = lowScoreCount;
            return result;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            int[] result = getRecord(s);
            Console.WriteLine(String.Join(" ", result));
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class Program
    {
        static int[] solve(int[] grades)
        {
            int[] result = new int[grades.Length];

            for (int i = 0; i <= grades.Length - 1; i++)
            {
                int score = grades[i];

                if (score >= 38)
                {
                    if ((score % 5) >= 3)
                        score = score + 5 - (score % 5);
                }

                result[i] = score;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] grades = new int[n];
            for (int grades_i = 0; grades_i < n; grades_i++)
            {
                grades[grades_i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result = solve(grades);
            Console.WriteLine(String.Join("\n", result));
        }
    }
}

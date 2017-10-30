using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Hourglass
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            bool initialized = false;
            int maxSum = 0;

            for (int iRow = 0; iRow <= 3; iRow++)
            {

                for (int iCol = 0; iCol <= 3; iCol++)
                {
                    int thisSum = arr[iRow][iCol] + arr[iRow][iCol + 1] + arr[iRow][iCol + 2] + arr[iRow + 1][iCol + 1]
                                     + arr[iRow + 2][iCol] + arr[iRow + 2][iCol + 1] + arr[iRow + 2][iCol + 2];

                    if (initialized == false)
                    {
                        maxSum = thisSum;
                        initialized = true;
                    }

                    if (thisSum > maxSum)
                    {
                        maxSum = thisSum;
                    }
                }

            }
            Console.WriteLine(maxSum);
        }
    }
}

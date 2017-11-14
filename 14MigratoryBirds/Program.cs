using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratoryBirds
{
    class Bird
    {
        public int Type { get; set; }
        public int Count { get; set; }
    }
    class Program
    {
        //My solution
        static int migratoryBirds(int n, int[] ar)
        {
            List<Bird> birds = new List<Bird>();

            for(int i=0;i <=ar.Length-1;i++)
            {
                if (birds.Any(x => x.Type == ar[i]))
                    birds.Where(x => x.Type ==ar[i]).FirstOrDefault().Count++;
                else
                    birds.Add(new Bird { Type = ar[i], Count = 1 });
            }

            var maxValue = birds.Max(x => x.Count);

            return birds.First(x => x.Count == maxValue).Type;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = migratoryBirds(n, ar);

            //Solution copied
            int b =  ar.GroupBy(a => a).OrderBy(a => a.Key).OrderByDescending(a => a.Count()).Select(a => a.Key).First();
            Console.WriteLine(b);
        }
    }
}

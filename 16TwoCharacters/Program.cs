using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoCharacters
{
    class Program
    {
        public static void removeConsecutive(List<char> sArr)
        {
            for (int i = 0; i <= sArr.Count - 1; i++)
            {
                if (i != 0)
                {
                    if (sArr[i] == sArr[i - 1])
                    {
                        sArr.RemoveAll(a => a == sArr[i]);
                        removeConsecutive(sArr);
                        break;
                    }
                }
            }
        }

        public static void removeRemaining(List<char> charsToKeep, List<char> sArr)
        {
            foreach (var item in sArr)
            {
                if (!charsToKeep.Contains(item))
                {
                    sArr.RemoveAll(x => x == item);
                    removeRemaining(charsToKeep, sArr);
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            int len = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();

            var sArr = new List<char>(s.ToCharArray());

            removeConsecutive(sArr);

            var charsToKeepGroup = sArr.GroupBy(a => a).OrderByDescending(a => a.Count()).Take(2).ToList();

            List<char> charsToKeep = new List<char>();

            foreach(var charKeep in charsToKeepGroup)
            {
                charsToKeep.Add(Convert.ToChar(charKeep.ToArray().GetValue(0)));
            }

            removeRemaining(charsToKeep, sArr);

            Console.WriteLine(sArr.Count());
        }
    }
}

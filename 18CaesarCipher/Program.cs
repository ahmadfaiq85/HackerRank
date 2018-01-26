using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            string result = caesarCipher(s, n, k);
            Console.WriteLine(result);
        }

        static string caesarCipher(string s, int n, int k)
        {
            char[] chars = s.ToCharArray();

            for (int i = 0; i <= n - 1; i++)
            {
                int charASC = (int)chars[i] + k;

                if ((int)chars[i] >= 97 && (int)chars[i] <= 122)
                {
                    if (charASC > 122)
                        while (charASC > 122)
                            charASC -= 26;

                    chars[i] = (char)charASC;
                }


                if ((int)chars[i] >= 65 && (int)chars[i] <= 90)
                {
                    if (charASC > 90)
                        while (charASC > 90)
                            charASC -= 26;

                    chars[i] = (char)charASC;
                }

            }

            return new string(chars);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExploration
{ 
    class Program
    {
        static int marsExploration(string s)
        {
            string sos = "SOS";
            int isos = 0;

            int errors = 0;
            
            for (int j = 0; j <= s.Length - 1; j++)
            {
                if (isos > 2)
                    isos = 0;

                if (s[j] != sos[isos])
                    errors++;

                isos++;
            }

            return errors;
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            int result = marsExploration(s);
            Console.WriteLine(result);
        }
    }
}

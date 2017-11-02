using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11StrongPassword
{
    class Program
    {
        static int minimumNumber(int n, string password)
        {
            int answer = 0;
            string numbers = "0123456789";
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";

            if (password.IndexOfAny(numbers.ToCharArray()) == -1) 
                answer++;
            if (password.IndexOfAny(lower_case.ToCharArray()) == -1)
                answer++;
            if (password.IndexOfAny(upper_case.ToCharArray()) == -1)
                answer++;
            if (password.IndexOfAny(special_characters.ToCharArray()) == -1)
                answer++;

            if ((password.Length) + answer < 6)
            {
                answer = 6 - password.Length;
            }
            return answer;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string password = Console.ReadLine();
            int answer = minimumNumber(n, password);
            Console.WriteLine(answer);
        }
    }
}

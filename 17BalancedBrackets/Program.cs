using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string s = Console.ReadLine();
                string result = isBalanced(s);
                Console.WriteLine(result);
            }
        }

        static string isBalanced(string s)
        {   
            Stack<char> charStack = new Stack<char>();

            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i].Equals('(') || s[i].Equals('[') || s[i].Equals('{'))
                    charStack.Push(s[i]);
                else
                {
                    if (charStack.Count == 0)
                        return "NO";

                    if (charStack.Peek().Equals('(') && s[i].Equals(')') ||
                        charStack.Peek().Equals('[') && s[i].Equals(']') ||
                        charStack.Peek().Equals('{') && s[i].Equals('}')
                        )
                    {
                        charStack.Pop();
                    }
                       
                    
                } 
            }

            if (charStack.Count == 0)
                return "YES";
            else
                return "NO";
        }

    }
}

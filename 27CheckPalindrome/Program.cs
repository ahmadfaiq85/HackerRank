using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            checkPalindrome("aabaa");
        }

        static bool checkPalindrome(string inputString)
        {

            char[] chars = inputString.ToCharArray();

            Stack<char> charStack = new Stack<char>();
            Queue<char> charQue = new Queue<char>();

            for (int i = 0; i <= chars.Length - 1; i++)
            {
                charStack.Push(chars[i]);
                charQue.Enqueue(chars[i]);

            }

            while (charStack.Count != 0)
            {
                char c1 = charStack.Pop();
                char c2 = charQue.Dequeue();

                if (c1 != c2)
                    return false;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListInsert
{
    class Program
    {
        public class Node
        {
            public int Data;
            public Node Next;

        }

        static void Main(string[] args)
        {
        }

        public static Node Insert(Node head, int x)
        {
            if (head == null)
            {
                Node newNode = new Node();
                newNode.Data = x;
                return newNode;
            }
            else if (head.Next == null)
            {
                head.Next = new Node();
                head.Next.Data = x;
                return head;
            }
            else
            {
                Insert(head.Next, x);
                return head;
            }

        }
    }
}

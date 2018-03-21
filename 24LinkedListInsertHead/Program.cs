using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListInsertHead
{
    class Program
    {
        public class Node
        {
            public int Data;
            public Node Next;

        }

        public static Node Insert(Node head, int x)
        {
            if (head == null)
            {
                head = new Node();
                head.Data = x;
                return head;
            }
            else
            {
                Node newHead = new Node();
                newHead.Data = x;
                newHead.Next = head;
                return newHead;
            }


        }

        static void Main(string[] args)
        {
        }
    }
}

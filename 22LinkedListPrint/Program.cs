using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPrint
{
    class Program
    {
        public class Node
        {
            public int Data;
            public Node Next;
             
        }

        public static void Print(Node head)
        {
            if (head == null)
                return;

            Node current = head;

            Console.WriteLine(current.Data);

            if (current.Next != null)
            {
                Print(current.Next);
            } 
        }
        static void Main(string[] args)
        {
            Node head = new Node();
            head.Data = 1;
            head.Next = new Node();
            head.Next.Data = 2;

            Print(head);

        }
    }
}
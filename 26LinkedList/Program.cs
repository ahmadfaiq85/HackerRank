using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26LinkedList
{
    class Program
    {
        public class Node
        {
            public Node Next;
            public int Data;

            public Node(int data)
            {
                Data = data;
            }
        }

        public class Linkedlist
        {
            public Node head;

            public void Append(int data)
            {
                if (head == null)
                {
                    head = new Node(data);
                    return;
                }
                Node current = head;
                while (current.Next != null)
                    current = current.Next;
                current.Next = new Node(data);
            }

            public void Prepend(int data)
            {
                Node newHead = new Node(data);
                newHead.Next = head;
                head = newHead;
            }

            public void Delete(int data)
            {
                if (head == null)
                    return;

                if (head.Data == data)
                {
                    head = head.Next;
                    return;
                }

                Node current = head;
                while (current.Next != null)
                {
                    if (current.Next.Data == data)
                    {
                        current.Next = current.Next.Next;
                        return;
                    }
                    current = current.Next;
                }
            }
        }

        static void Main(string[] args)
        {
            Linkedlist linkedlist = new Linkedlist();

            linkedlist.Append(10);
            linkedlist.Append(5);
            linkedlist.Append(20);
            linkedlist.Append(3);

            linkedlist.Delete(20);

            Node head = linkedlist.head;
            
        }
    }
}

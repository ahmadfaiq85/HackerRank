using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        public class Node
        {
            public Node Left;
            public Node Right;
            public int Data;

            public Node(int data)
            {
                this.Data = data;
            }

            public void Insert(int value)
            {
                if (value <= Data)
                {
                    if (Left == null)
                        Left = new Node(value);
                    else
                        Left.Insert(value);
                }
                else
                {
                    if (Right == null)
                        Right = new Node(value);
                    else
                        Right.Insert(value);
                }
            }

            public bool Contains(int value)
            {
                if (Data == value)
                {
                    return true;
                }
                else if (value < Data)
                {
                    if (Left == null)
                        return false;
                    else
                        return Left.Contains(value);
                } else
                {
                    if (Right == null)
                        return false;
                    else
                        return Right.Contains(value);
                }
            }

            public void printInOrder()
            {
                if (Left != null)
                    Left.printInOrder();
                Console.WriteLine(Data);
                if (Right != null)
                    Right.printInOrder();
            }
        }

        static void Main(string[] args)
        {
            Node tree = new Node(10);
            tree.Insert(12);
            tree.Insert(15);
            tree.Insert(11);
            tree.Insert(2);

            tree.printInOrder();
        }
    }
}

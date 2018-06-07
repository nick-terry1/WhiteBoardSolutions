using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// author: nick terry 
// date: 7 june 2018
// DEFINATELY one of those problems that was easier to write by hand than on the computer.  
// Trying to keep track of what head.Next.Next or head.Next represented at any point during the recursive process 
// was tough to just think my way through. Writing an input/output chart made all the difference.
// Where head used to point to the Node referencing head.Next - now head.Next must point to the current node head. 

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node test5 = new Node(null, 5);
            Node test4 = new Node(test5, 4);
            Node test3 = new Node(test4, 3);
            Node test2 = new Node(test3, 2);
            Node test1 = new Node(test2, 1);

            Node.PrintAllNodes(test1); // prints 1 2 3 4 5
            Node.ReverseNode(test1);
            Node.PrintAllNodes(test1); // prints 1
            Node.PrintAllNodes(test5); // prints 5 4 3 2 1

        }

        
    }

    public class Node
    {
        public Node Next { get; set; }
        public int Value { get; set; }

        public Node(Node Next, int Value)
        {
            this.Next = Next;
            this.Value = Value;
        }

        public static void ReverseNode(Node head)
        {
            // Recursion stops when the end is found
            if (head.Next.Next == null)
            {
                head.Next.Next = head;
                head.Next = null;
                return;
            }
            // then reassign Next references as the program cycles out
            else
            {
                ReverseNode(head.Next);
                head.Next.Next = head;
                head.Next = null;
            }
        }

        // this method prints all the node values associated with the arguement node.
        public static void PrintAllNodes(Node head)
        {
            // if the program inserts a null value for the head
            if (head == null)
            {
                return;
            }
            else
            { 
                Console.WriteLine(head.Value);
                if (head.Next != null)
                {
                    PrintAllNodes(head.Next);
                }
                else
                {
                    return;
                }
            }
        }
    }
}

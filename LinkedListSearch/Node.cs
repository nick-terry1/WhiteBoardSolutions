using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// created by Nick Terry
// last edit: may 21, 2018
// desc: creates a linked list class with a search method that looks for an integer value

namespace LinkedListNode
{
    public class Node
    {
        public int value { get; set; }
        public Node next { get; set; }

        public Node(int value, Node head)
        {
            next = head;
            this.value = value;
        }

        public static bool Search(Node head, int find)
        {
            try
            {
                if (head == null)
                {
                    Console.WriteLine("ERROR: The head cannot be null");
                    return false;
                }
                else if (head.value == find)
                {
                    return true;
                }
                else if (head.next == null)
                {
                    return false;
                }
                else return Search(head.next, find);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                return false;
            }
        }
    }
}

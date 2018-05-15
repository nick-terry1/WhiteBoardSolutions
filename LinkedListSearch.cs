using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListWB
{
    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node(1, null);
            Node second = new Node(2, first);
            Node third = new Node(3, second);
            Node fourth = new Node(4, third); // last node entered is the head

            Console.WriteLine(Node.Search(fourth, 1));
        }
    }

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
            if (head.value == find)
            {
                return true;
            }
            if (head.next == null)
            {
                return false;
            }
            else return Search(head.next, find);
        }
    }
}

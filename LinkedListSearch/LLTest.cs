using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListNode;

namespace LLTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTrueCase()
        {
            Node first = new Node(1, null);
            Node second = new Node(2, first);
            Node third = new Node(3, second);
            Node fourth = new Node(4, third);

            Node.Search(fourth, 2);
            
            // returns true
        }
        [TestMethod]
        public void TestFalseCase()
        {
            Node b1 = new Node(50, null);
            Node b2 = new Node(25, b1);

            Node.Search(b2, 10);

            // returns false
        }
        [TestMethod]
        public void TestNullHead()
        {
            Node nullHead = null;

            Node.Search(nullHead, 4);

            // returns "ERROR: The head cannot be null" \n false
        }
    }
}

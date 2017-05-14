using System;

namespace LinkedList
{
    public class Node
    {
        public int data { get; set; }
        public Node Next { get; set; }
    }

    class TraverseLinkedList
    {
        static void Main(string[] args)
        {
            var first = new Node { data = 1 };
            var middle = new Node { data = 2 };
            var last = new Node { data = 3 };

            first.Next = middle;
            middle.Next = last;

            // iterate through linked-list
            Node node = first;
            while(node !=null)
            {
                Console.WriteLine(node.data);
                node = node.Next;
            }

            Console.ReadLine();            
        }
    }
}

using System;

namespace LinkedList
{

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    class LinkedList
    {
        static void Main(string[] args)
        {
            var first = new Node { Value = 1 };
            var middle = new Node { Value = 2 };
            var last = new Node { Value = 3 };

            first.Next = middle;
            middle.Next = last;

            // iterate through linked-list
            Node node = first;
            while(node !=null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }

            Console.ReadLine();
            
        }
    }
}

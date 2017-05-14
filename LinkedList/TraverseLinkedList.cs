using System;

namespace LinkedList
{
    class TraverseLinkedList
    {
        static void Main(string[] args)
        {
            // create a LinkedList 1-> 2-> 3
            var first = new Node(1);
            var middle = new Node(2);
            var last = new Node(3);

            first.Next = middle;
            middle.Next = last;

            Console.Write("Created LinkedList 1->2->3 : ");
            var node = first;

            while(node !=null)
            {
                Console.WriteLine(node.data);
                node = node.Next;
            }

            Console.ReadLine();            
        }
    }
}

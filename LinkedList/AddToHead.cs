using System;

namespace LinkedList
{    
    class AddToHead
    {
        static void Main(string[] args)
        {             
            Console.Write("Enter data you want to add to the Head of linkedList 1->2->3 : ");

            var data = Int32.Parse(Console.ReadLine());

            AddDataToHead(data);                       
        }

        public static void AddDataToHead(int data)
        {
            // create a LinkedList 1-> 2-> 3
            var first = new Node(1);
            var middle = new Node(2);
            var last = new Node(3);

            first.Next = middle;
            middle.Next = last;

            var node = new Node(data);
            node.Next = first;
           
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.Next;
            }

            Console.ReadLine();
        }
    }
}

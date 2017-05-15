using System;

namespace LinkedList
{
    class AddToTail
    {
        static void Main(string[] args)
        {
            Console.Write("Enter data you want to add to the Tail of linkedList 1->2->3 : ");

            var data = Int32.Parse(Console.ReadLine());

            AddDataToTail(data);
        }

        public static void AddDataToTail(int data)
        {
            // create a LinkedList 1-> 2-> 3
            var first = new Node(1);
            var middle = new Node(2);
            var last = new Node(3);

            first.Next = middle;
            middle.Next = last;
            
            // data passed to be added to Tail
            var tailData = new Node(data);
            
            if(first == null)
            {
                first = tailData;
                Console.WriteLine(first.data);
            }

            // traverse linkedlist until end and then add data to tail
            Node temp = first;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = tailData;

            // data added to tail, traverse from head and print the new linkedlist e.g. 1-> 2-> 3-> 4
            var head = first;
            while(head !=null)
            {
                Console.WriteLine(head.data);
                head = head.Next;
            }

            Console.ReadLine();
        }
    }
}

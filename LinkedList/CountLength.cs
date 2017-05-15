using System;

namespace LinkedList
{
    class CountLength
    {
        static void Main(string[] args)
        {
            Console.Write($"Lenth of linkedList 1->2->3 : {Lenth()}");
            Console.ReadLine();
        }

        public static int Lenth()
        {
            // create a LinkedList 1-> 2-> 3
            var first = new Node(1);
            var middle = new Node(2);
            var last = new Node(3);

            first.Next = middle;
            middle.Next = last;

            if (first == null)
            {
                return 0;
            }

            // traverse linkedlist until end 
            Node temp = first;
            int count = 1;
            while (temp.Next != null)
            {
                count++;
                temp = temp.Next;
            }

           return count;            
        }
    }
}

using System;

namespace LinkedList
{
    class NthFromEnd
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter the Nth position of Element from End you wish to serach from linkedList 1->2->3->4->5->6 : ");
            var n = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Nth No. frm the End is : {FindNthFromEnd(n)}");

            Console.ReadLine();
        }

        public static int FindNthFromEnd(int n)
        {
            // create a LinkedList 1-> 2-> 3
            var first = new Node(1);
            var second = new Node(2);
            var third = new Node(3);
            var fourth = new Node(4);
            var fifth = new Node(5);
            var sixth = new Node(6);

            first.Next = second;
            second.Next = third;
            third.Next = fourth;
            fourth.Next = fifth;
            fifth.Next = sixth;
            
            if (first == null || n <= 0)
            {
                return 0;
            }

            // create two pointers F (Front) and B (Back)
            // Point both to 1st node
            Node F = new Node();
            F.Next = first;
            Node B = new Node();
            B.Next = first;

            //Move F until n times
            for(int i=0;i<n;i++)
            {
                if(F==null)
                {
                    return 0;
                }
                F = F.Next;
            }

            //Move F from n location and B from 1st node until N is Null
            // Now B will be at the nth position from the end
            while (F != null)
            {
                F = F.Next;
                B = B.Next;
            }
            return B.data;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Numbers
{
    public class RemoveDuplicateNumbers
    {
        static void Main(string[] args)
        {
            int[] num = new int[] {1,2,2,3,4,5,6,6,7,8,9,9};

            Console.WriteLine($"Total Count of Strings in Array {num.Length}");

            RemoveDuplicateNumber(num);

            Console.ReadLine();
        }

        public static void RemoveDuplicateNumber(int[] numAray)
        {
            HashSet<int> hset = new HashSet<int>(numAray);

            foreach (var n in hset)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine($"Total Count after removing Duplicates {hset.Count.ToString()}");
        }
    }
}


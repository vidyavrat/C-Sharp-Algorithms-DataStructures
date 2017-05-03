using System;
using System.Collections.Generic;

namespace Strings
{
    public class RemoveDuplicateStrings
    {
        static void Main(string[] args)
        {
            string[] names = new string[] {
                "vidya",
                "Vrat",
                "Agarwal",
                "vidya",
                "vrat",
                "arshika",
                "pearly",
                "seattle"
            };

            Console.WriteLine($"Total Count of Strings in Array {names.Length}");

            RemoveDuplicateString(names);

            Console.ReadLine();
        }

        public static void RemoveDuplicateString(string[] strAray)
        {
            HashSet<string> hset = new HashSet<string>(strAray);

            foreach(var s in hset)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine($"Total Count after removing Duplicates {hset.Count.ToString()}");            
        }
    }
}


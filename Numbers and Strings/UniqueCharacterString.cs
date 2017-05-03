using System;
using System.Collections.Generic;

namespace Strings
{
    public class UniqueCharacterString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            var s = Console.ReadLine();

            Console.WriteLine(IsUniqueCharacherString(s));

            Console.ReadLine();
        }

        public static bool IsUniqueCharacherString(string str)
        {
            Dictionary<char, int> kv = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (kv.ContainsKey(c))
                {
                    return false;
                }
                else
                {
                    kv.Add(c, 1);
                }
            }
            return true;
        }
    }
}

using System;

namespace Strings
{
    public class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if Two Strings are Anagram or now?, E.g. TOP and POT are anagram");

            Console.Write("Enter 1st String : ");
            string s1 = Console.ReadLine();
            Console.Write("Enter 2nd String : ");
            string s2 = Console.ReadLine();

            bool result = IsAnagram(s1, s2);
            Console.WriteLine(result);

            Console.ReadLine();
        }
        private static bool IsAnagram(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrWhiteSpace(str1) 
                || string.IsNullOrEmpty(str2) || string.IsNullOrWhiteSpace(str2))
            {
                return false;
            }
            else if (str1.Length != str2.Length)
            {
                return false;
            }
            else
            {                
                
                var char1 = str1.ToLower().ToCharArray();
                Array.Sort(char1);
                var char2 = str2.ToLower().ToCharArray();               
                Array.Sort(char2);

                for (int i = 0; i <= str1.Length - 1; i++)
                {
                    if (char1[i] == char2[i])
                    {
                        i++;
                        if (i == str2.Length)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}

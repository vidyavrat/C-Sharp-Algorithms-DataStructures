using System;

namespace Strings
{
    public class PalindromeUsingReverseString
    {
        static void Main(string[] args)
        {

            // Two approaches:

            //#1 - Reverse the string and then compare both
            var str ="Civic".ToLower();
            var newStr = string.Empty;

            // Reverese string
            for (var i = str.Length - 1; i >= 0; i--)
            {
                newStr += str[i];
            }
            Console.WriteLine(newStr);

            // check if reverse and original are equal then palindrome
            if (str.Equals(newStr))
            {
                Console.WriteLine("Is Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }

            Console.ReadLine();
        }
    }
}

using System;

namespace Strings
{
    public class ReverseString
    {
        static void Main(string[] args)
        {
            var str = "aBcD";
            var newStr = string.Empty;

            // Reverese string
            for (var i = str.Length - 1; i >= 0; i--)
            {
                newStr += str[i];
            }
            Console.WriteLine(newStr);
            
            Console.ReadLine();
        }
    }
}

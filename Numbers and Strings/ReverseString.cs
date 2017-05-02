using System;
using System.Text;

namespace Strings
{
    public class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String You Wish To Be Reversed! : ");
            var str1 = Console.ReadLine();

            Console.WriteLine(StringReverse(str1));

            Console.ReadLine();
        }

        public static string StringReverse(string str)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
            {
                return null;
            }
            else if (str.Length == 1)
            {
                return str;
            }
            else
            {
                var sb = new StringBuilder();

                // Reverese string
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    sb.Append(str[i]);
                }

                return sb.ToString();
            }
        }
    }
}

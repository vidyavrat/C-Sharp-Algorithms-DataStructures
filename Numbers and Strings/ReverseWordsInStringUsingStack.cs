using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class ReverseWordsInStringUsingStack
    {
        static void Main(string[] args)
        {
            int result = 0;
            string x = "This is test to reverse string";
            Console.WriteLine($"Original string: {x}");
            //Trim whitespace from beginning and end of string
            x = x.Trim();

            //Necessary because foreach will execute once with empty string returning 1
            //if (x == "")
            //    return 0;

            //Ensure there is only one space between each word in the passed string
            while (x.Contains("  "))
                x = x.Replace("  ", " ");

            var wordStack = new Stack<string>();
            
            //push words into the stack
            foreach (string y in x.Split(' '))
            {
                wordStack.Push(y);
                wordStack.Push(" ");               
            }
          
            Console.WriteLine($"Total Words in Stack : {wordStack.Count}");

            var sb = new StringBuilder();
            while(wordStack.Count >0)
            {
                sb.Append(wordStack.Pop());
            }
            Console.WriteLine(sb.ToString().Trim());

            Console.ReadLine();
        }
    }
}

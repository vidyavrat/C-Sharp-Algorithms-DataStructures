using System;
using System.Text;

namespace Strings
{
    class RemoveSpacesFromString
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();

            Console.WriteLine("Input a String you would like to remove SPACES from");
            var str1 = Console.ReadLine();        
            
            for (int i = 0; i <= str1.Length - 1; i++)
            {
                if (str1[i].ToString() == " ")
                {
                    sb.Append("");
                }
                else
                {
                    sb.Append(str1[i]);                    
                }                
            }
            Console.WriteLine(sb.ToString());

            Console.ReadLine();
        }
    }
}

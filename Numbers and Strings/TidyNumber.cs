using System;

namespace Numbers
{
    public class TidyNumber
    {
        // Tidy Number is a number in which numbers are either increasing or remains same.
        // 1234, 2233 are Tidy
        // 2211 is not Tidy

        static void Main(string[] args)
        {
            Console.Write("Enter an Integer Number : ");
            var num = Int32.Parse(Console.ReadLine());

            Console.WriteLine(IsTidy(num));
            Console.ReadLine();
        }

        public static bool IsTidy(int num)
        {            
            var val = num.ToString();
            var count =1;
            for(int i=0;i<val.Length -1;i++)
            {
                if(val[i+1] >= val[i])
                {
                    count++;
                }
            }

            if(count == val.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
using System;

namespace Numbers
{
    class FibonacciSeries
    {
        static void Main(string[] args)
        {
            Console.Write("Enter lenth of Series : ");
            var f = Int32.Parse(Console.ReadLine());

            for(int i=0; i <= f;i++)
            {
                Console.Write(FibonacciNumber(i));
            }

            Console.ReadLine();
        }

        public static int FibonacciNumber(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
        }
    }
}
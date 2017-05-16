using System;

namespace Numbers
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.Write("Enter lenth of Series : ");
            var length = Int32.Parse(Console.ReadLine());

            PintFizzBuzz(length);
            
            Console.ReadLine();
        }

        public static void PintFizzBuzz(int length)
        {
            if (length <= 0)
            {
                Console.WriteLine("no data");
            }

            for (int i=1; i<=length; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;

                if(fizz)
                {
                    Console.WriteLine($"{i} : Fizz");
                }
                else if(buzz)
                {
                    Console.WriteLine($"{i} : Buzz");
                }
                else
                {
                    Console.WriteLine($"{i} FizzBuzz");
                }
            }
        }
    }
}
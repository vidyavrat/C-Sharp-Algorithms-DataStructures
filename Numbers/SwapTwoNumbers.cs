using System;

namespace Numbers
{
    public class SwapTwoNumbers
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine($"x: {x} y: {y}");

            Console.ReadLine();
        }
    }
}

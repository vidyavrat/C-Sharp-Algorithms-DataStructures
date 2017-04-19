using System;

namespace Sorting
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] a = { 30, 20, 50, 40, 10,89,1000,78,56,0,-1,-2,1,5000,100,2 };
            int t;
            Console.WriteLine("The Array is : ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            for (int i = a.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int highValue = a[j];

                        a[j] = a[j + 1];
                        a[j + 1] = highValue;
                    }
                }
            }
            Console.WriteLine("The Sorted Array :");
            foreach (int aray in a)
                Console.Write(aray + " ");
            Console.ReadLine();
        }
    }
}

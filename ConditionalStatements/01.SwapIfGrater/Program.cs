using System;
using System.Linq;

namespace _01.SwapIfGrater
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = input.Take(input.Length).Select(int.Parse).ToArray();

            int a = numbers[0];
            int b = numbers[1];
            int c = 0;

            if (a > b)
            {
                c = a;
                a = b;
                b = c;
            }

            Console.WriteLine("{0} {1}", a, b);
        }
    }
}

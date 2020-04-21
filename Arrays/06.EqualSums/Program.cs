using System;
using System.Linq;

namespace _06.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = input.Take(input.Length).Select(int.Parse).ToArray();

            if (numbers.Length == 1)
            {
                Console.Write("0");
            } 
            else
            {
                bool hasAtleastOneSum = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    int rigthSliceSum = numbers.Skip(i + 1).Take((numbers.Length - (i + 1))).ToArray().Sum();
                    int leftSliceSum = numbers.Take(i).ToArray().Sum();

                    if (rigthSliceSum == leftSliceSum)
                    {
                        hasAtleastOneSum = true;
                        Console.Write("{0}", i);
                    }
                }
                if (!hasAtleastOneSum)
                {
                    Console.Write("no");
                }
            }
        }
    }
}

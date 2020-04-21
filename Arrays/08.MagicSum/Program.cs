using System;
using System.Linq;

namespace _08.MagicSum
{
    public class SumsPair
    {
        public int number;
        public int occurances;

        public SumsPair(int number, int occurances)

        {
            this.number = number;
            this.occurances = occurances;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = input.Take(input.Length).Select(int.Parse).ToArray();

            int expectedSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextNumber = numbers[j];
                    if (expectedSum == currentNumber + nextNumber)
                    {
                        Console.WriteLine("{0} {1}", currentNumber, nextNumber);
                    }
                }
            }
        }
    }
}

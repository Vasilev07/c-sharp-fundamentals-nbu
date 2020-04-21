using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    public class Sequence
    {
        public int number;
        public int occurances;
        
        public Sequence(int number, int occurances)
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

            List<Sequence> numberOccurances = new List<Sequence>();
            int occurances = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    numberOccurances.Add(new Sequence(numbers[i], occurances));
                    break;
                }

                int currentNumber = numbers[i];
                int nextNumber = numbers[i + 1];

                
                if (currentNumber == nextNumber)
                {
                    ++occurances;
                    continue;
                }

                numberOccurances.Add(new Sequence(currentNumber, occurances));
                occurances = 1;
                
            }

            int maxOccurances = numberOccurances.Max(t => t.occurances);
            string result;
            int times;
            foreach (var sequence in numberOccurances)
            {
                if (maxOccurances == sequence.occurances)
                {
                    result = sequence.number.ToString();
                    times = sequence.occurances;

                    for (int i = 0; i < times; i++)
                    {
                        Console.Write(result + " ");
                    }

                    break;
                }
            }
        }
    }
}

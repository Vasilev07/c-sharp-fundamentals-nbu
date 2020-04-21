using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            long[] numbers = input.Take(input.Length).Select(long.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                long potentialTopInt = numbers[i];
                
                bool isTopInt = false;
                if (i == numbers.Length - 1)
                {
                    isTopInt = true;
                }
                else
                {
                    long[] numbersSliceToCheck = numbers.Skip(i + 1).Take((numbers.Length - (i + 1))).ToArray();

                    for (int j = 0; j < numbersSliceToCheck.Length; j++)
                    {
                        if (potentialTopInt > numbersSliceToCheck[j])
                        {
                            isTopInt = true;
                        }
                        else
                        {
                            isTopInt = false;
                            break;
                        }
                    }
                }
                

                if (isTopInt)
                {
                    Console.Write("{0} ", potentialTopInt);
                }
                isTopInt = false;
            }
        }
    }
}

using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] numbers = input.Take(input.Length).Select(int.Parse).ToArray();

            int numberOfRotations = int.Parse(Console.ReadLine());

           /* if (numbers.Length % numberOfRotations == 0 && numberOfRotations != 1)
            {
                foreach (var item in numbers)
                {
                    Console.Write("{0} ", item);
                }
            }
            else
            {*/
                for (int i = 0; i < numberOfRotations; i++)
                {
                    int first = numbers[0];

                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (j == numbers.Length - 1){
                            numbers[numbers.Length - 1] = first;
                            break;
                        }

                        numbers[j] = numbers[j + 1];
                    }

                }


            Console.WriteLine("{0}", string.Join(" ", numbers));
            /*}*/
        }
    }
}

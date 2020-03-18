using System;

namespace _03.ZigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int[] firstArrayToPrint = new int[numberOfInputs];
            int[] secondArrayToPrint = new int[numberOfInputs];

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] numbers = Console.ReadLine().Split(' ');
                if (i % 2 == 0)
                {
                    firstArrayToPrint.SetValue(int.Parse(numbers[0]), i);
                    secondArrayToPrint.SetValue(int.Parse(numbers[1]), i);
                } else
                {
                    firstArrayToPrint.SetValue(int.Parse(numbers[1]), i);
                    secondArrayToPrint.SetValue(int.Parse(numbers[0]), i);
                }
            }

            foreach (var item in firstArrayToPrint)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            foreach (var item in secondArrayToPrint)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}

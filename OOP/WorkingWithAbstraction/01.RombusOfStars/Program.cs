using System;
using System.Linq;

namespace _01.RombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int stars = int.Parse(Console.ReadLine());

            for (int i = 1; i <= stars; i++)
            {
                printRow(stars - i, i);
            }

            for (int i = stars - 1; i > 0; i--)
            {
                printRow(stars - i, i);
            }
        }

        private static void printRow(int numberOfEmptyStrings, int numberOfStars)
        {
            string emptyStrings = new String(' ', numberOfEmptyStrings);
            string stars = new String('*', numberOfStars);
         
            Console.WriteLine("{0}{1}", emptyStrings, String.Join(" ", stars.ToArray()));
        }
    }
}

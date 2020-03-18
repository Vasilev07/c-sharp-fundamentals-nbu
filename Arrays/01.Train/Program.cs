using System;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] people = new int[wagons];
            for (int i = 0; i < wagons; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
            }

            foreach (var item in people)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
            Console.WriteLine(people.Sum());
        }
    }
}

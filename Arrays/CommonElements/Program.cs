using System;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            foreach (var word in firstArray)
            {
                bool wordExist = Array.Exists(secondArray, secondWord => secondWord == word);

                if (wordExist)
                {
                    Console.Write("{0} ", word);
                }
            }
        }
    }
}

using System;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            if(score >= 1 && score <= 3)
            {
                score *= 10;
            } else if (score >= 4 && score <= 6)
            {
                score *= 100;
            }
            else if (score >= 7 && score <= 9)
            {
                score *= 1000;
            } else
            {
                Console.WriteLine("Invalid Score");
            }

            Console.WriteLine("SCORE {0}", score);
        }
    }
}

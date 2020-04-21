using System;
using System.Linq;

namespace _03.CheckForPlayCard
{
    public enum CardsWithNumber {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nince = 9,
        Ten = 10,
    }
    public enum CardsWithSymbols { J, Q, K, A }
    class Program
    {
        static void Main(string[] args)
        {
            String checkIfCard = Console.ReadLine();
            String[] cards = new String[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            bool cardExist = cards.Contains(checkIfCard);
            if (cardExist)
            {
                Console.WriteLine("YES");
            } else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

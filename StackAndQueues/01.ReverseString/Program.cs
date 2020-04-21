using System;
using System.Collections;
using System.Linq;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Stack stack = new Stack(input);

            for (int i = 0; i < input.Length; i++)
            {
                string currentElement = stack.Pop().ToString();
                char[] currentElementAsArray = currentElement.ToCharArray();
                Array.Reverse(currentElementAsArray);

                Console.Write("{0} ", new string(currentElementAsArray));
            }
        }
    }
}

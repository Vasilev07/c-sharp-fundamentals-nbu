using System;

namespace _04.StringsAndObjects
{
    class concatenateStrings
    {
        public String concatenateString(string firstString, string secondString)
        {
            return firstString + " " + secondString;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String hello = "Hello ";
            String world = "World";

            String concatenationToPrint = new concatenateStrings().concatenateString(hello, world);

            Console.WriteLine(concatenationToPrint);
        }
    }
}

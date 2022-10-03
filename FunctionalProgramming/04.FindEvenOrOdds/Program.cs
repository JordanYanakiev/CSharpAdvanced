using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvenOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> even = number => number % 2 == 0;
            Predicate<int> odd = number => number % 2 != 0;
            bool isEven = true;
            int[] boundaries = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lowerBand = boundaries[0];
            int upperBound = boundaries[1];
            List<int> result = new List<int>();

            string evenOrOdd = Console.ReadLine();

            for (int i = lowerBand; lowerBand <= upperBound; lowerBand++)
            {
                if (evenOrOdd == "even" && even(lowerBand))
                {
                    result.Add(lowerBand);
                }
                else if(evenOrOdd == "odd" && odd(lowerBand))
                {
                    result.Add(lowerBand);
                }
            }

                foreach (var num in result)
                {
                  Console.Write(num + " ");
                }
            

        }
    }
}

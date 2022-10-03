using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int divisibleNumber = int.Parse(Console.ReadLine());

            Func<List<int>, int, List<int>> reverseNumbers = (listWithNums, diviseNum) =>
            {
               listWithNums.Reverse();
                List<int> newInts = new List<int>();

                foreach (var num in listWithNums)
                {
                    if (num % diviseNum != 0)
                    {
                        newInts.Add(num);
                    }
                }

                return newInts;
            };

            Console.WriteLine(string.Join(" ", reverseNumbers(numbers, divisibleNumber)));

        }
    }
}

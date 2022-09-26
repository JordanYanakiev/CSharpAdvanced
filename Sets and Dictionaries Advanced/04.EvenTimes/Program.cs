using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEntries = int.Parse(Console.ReadLine());
            HashSet<int> numbers = new HashSet<int>();
            int counter = 1;
            int doubleNumber = 0;


            for (int i = 0; i < numberOfEntries; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (numbers.Contains(number) && counter == 1)
                {
                    doubleNumber = number;
                    counter++;
                }
                numbers.Add(number);
            }

            Console.WriteLine(doubleNumber);

        }
    }
}

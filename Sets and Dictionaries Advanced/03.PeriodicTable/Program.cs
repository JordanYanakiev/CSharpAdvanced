using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEntries = int.Parse(Console.ReadLine());
            SortedSet<string> periodicTable = new SortedSet<string>();

            for (int i = 0; i < numberOfEntries; i++)
            {
                string[] elementsInput = Console.ReadLine().Split();

                for (int j = 0; j < elementsInput.Length; j++)
                {
                    periodicTable.Add(elementsInput[j]);
                }
            }

            

            foreach (var element in periodicTable)
            {
                Console.Write(element + " ");
            }
        }
    }
}

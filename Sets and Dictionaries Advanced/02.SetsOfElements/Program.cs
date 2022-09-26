using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setsLenght = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            HashSet<int> set01 = new HashSet<int>();
            HashSet<int> set02 = new HashSet<int>();

            for (int i = 0; i < setsLenght[0]; i++)
            {
                set01.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < setsLenght[1]; i++)
            {
                set02.Add(int.Parse(Console.ReadLine()));
            }

            set01.IntersectWith(set02);

            Console.WriteLine(string.Join(" ", set01));

        }
    }
}

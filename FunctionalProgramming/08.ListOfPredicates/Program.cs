using System;
using System.Linq;

namespace _08.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeEnd = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                             .Select(int.Parse).ToArray();
            bool isDivisibleToAll = false;
            
            for (int i = 1; i <= rangeEnd; i++)
            {
                Predicate<int> divideCheck = divider => i % divider == 0;

                foreach (var div in dividers)
                {
                    if (divideCheck(div))
                    {
                        isDivisibleToAll = true;
                        continue;
                    }
                    else 
                    {
                        isDivisibleToAll = false;
                        break; 
                    }
                }

                if (isDivisibleToAll)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

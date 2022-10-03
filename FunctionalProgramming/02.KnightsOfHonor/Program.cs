using System;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printName = x => Console.WriteLine("Sir " + x);
            string[] names = Console.ReadLine().Split();

            foreach (var name in names)
            {
                printName(name);
            }
        }
    }
}

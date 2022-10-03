using System;
using System.Linq;

namespace _01.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printName = x => Console.WriteLine(x);
            string[] names = Console.ReadLine().Split();
            
            foreach (var name in names)
            {
                printName(name);
            }

        }
    }
}

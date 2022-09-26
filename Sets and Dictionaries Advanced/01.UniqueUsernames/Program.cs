using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEntries = int.Parse(Console.ReadLine());

            HashSet<string> userNames = new HashSet<string>();

            for (int i = 0; i < numberOfEntries; i++)
            {
                userNames.Add(Console.ReadLine());
            }

            foreach (var userName in userNames)
            {
                Console.WriteLine(userName);
            }

        }
    }
}

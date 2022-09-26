using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            SortedDictionary<char, int> countChars = new SortedDictionary<char, int>();

            for (int i = 0; i < inputText.Length; i++)
            {
                if (!countChars.ContainsKey(inputText[i]))
                {
                    countChars.Add(inputText[i], 1);
                }
                else
                {
                    countChars[inputText[i]] += 1;
                }
            }

            foreach (var csymbol in countChars)
            {
                Console.WriteLine($"{csymbol.Key}: {csymbol.Value} time/s");
            }
        }
    }
}

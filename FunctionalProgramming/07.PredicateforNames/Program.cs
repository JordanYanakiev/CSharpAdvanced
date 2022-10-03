using System;

namespace _07.PredicateforNames
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfCharacters = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Predicate<string> nameLenght = name => name.Length <= numberOfCharacters; 

            foreach (var name in names)
            {
                if (nameLenght(name) == true)
                {
                    Console.WriteLine(name);
                }
            }

        }
    }
}

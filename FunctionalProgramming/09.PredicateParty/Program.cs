using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> guestList = new List<string>();
            string[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = cmd[0];
            string filter = null;
            string value = null;
            
            while (command != "Party!")
            {
                if (cmd.Length > 1)
                {
                    filter = cmd[1];
                    value = cmd[2];
                }
                
                if (command == "Remove")
                {
                    names.RemoveAll(GetPredicate(filter, value));
                }
                else if (command == "Double")
                {
                    List<string> peopleToDouble = names.FindAll(GetPredicate(filter, value));

                    int index = names.FindIndex(GetPredicate(filter, value));

                    if (index >= 0)
                    {
                        names.InsertRange(index, peopleToDouble);
                    }
                }

                cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                command = cmd[0];
            }

            if (names.Any())
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

            Console.WriteLine(string.Join(", ", guestList));
        }

        private static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "StartsWith":
                    return s => s.StartsWith(value);
                    break;
                case "EndsWith":
                    return s => s.EndsWith(value);
                    break;
                case "Length":
                    return s => s.Length == int.Parse(value);
                    break;
                default:
                    return default(Predicate<string>);
            }
        }
    }
}

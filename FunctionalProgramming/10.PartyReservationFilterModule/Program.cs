using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> invitations = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> actualList = new List<string>();
            Dictionary<string, Predicate<string>> filters = new Dictionary<string, Predicate<string>>();
            string[] commands = Console.ReadLine().Split(";");
            string command = commands[0];
            string filter = commands[1];
            string value = commands[2];

            while (command != "Print")
            {
                filter = commands[1];
                value = commands[2];

                if (command == "Add filter")
                {
                   filters.Add(filter + value, GetPredicate(filter, value));
                }
                else if (command == "Remove filter")
                {
                    filters.Remove(filter + value);
                }

                commands = Console.ReadLine().Split(";");
                command = commands[0];
            }

            foreach (var filterr in filters)
            {
                invitations.RemoveAll(filterr.Value);
            }

            Console.WriteLine(string.Join(" ", invitations));
        }

        


        private static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "Starts with":
                    {
                        return s => s.StartsWith(value);
                        break;
                    }
                case "Ends with":
                    {
                        return s => s.EndsWith(value);
                        break;
                    }
                case "Length":
                    {
                        return s => s.Length <= int.Parse(value);
                        break;
                    }
                case "Contains":
                    {
                        return s => s.Contains(value);
                        break;
                    }
                default:
                    {
                        return default(Predicate<string>);
                    }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNumber = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> namesThatMeetNumber = new List<string>();


            Func<string, int, bool> checkLettersSum = (name, number) =>
            {
                int sum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    sum  += (int)name[i];
                }

                if (sum >= number)
                {
                    return true;
                }

                return false;
            };

            Func<List<string>, Func<string, int, bool>, string> getResult = (names, checkLettersSum) =>
            {
                string nameOut = null;
                for (int i = 0; i < names.Count; i++)
                {
                   if ( checkLettersSum(names[i], targetNumber))
                    {
                        nameOut = names[i];
                        break;
                    }
                }

                return nameOut.ToString();
            };

            namesThatMeetNumber.Add(getResult(names, checkLettersSum));

            Console.WriteLine(string.Join(" ", namesThatMeetNumber));



        }
    }
}

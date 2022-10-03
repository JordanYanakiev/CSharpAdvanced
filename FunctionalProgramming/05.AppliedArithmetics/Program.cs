using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int[], int[]> add = (numbers) =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i]++;
                }

                return numbers;
            };

            Func<int[], int[]> multiply = (numbers) =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] *= 2;
                }

                return numbers;
            };
            
            Func<int[], int[]> subtract = (numbers) =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] -= 1;
                }

                return numbers;
            };
            
            Func<int[], string> print = (numbers) =>
            {
                string printNums = String.Join(" ", numbers);
                Console.WriteLine(printNums);
                return printNums;
            };

            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string cmd = Console.ReadLine();

            while (cmd != "end")
            {

                if (cmd == "add")
                {
                    add(numbers);
                }
                else if (cmd == "multiply")
                {
                    multiply(numbers);
                }
                else if (cmd == "subtract")
                {
                    subtract(numbers);
                }
                else if (cmd == "print")
                {
                    print(numbers);
                }

                cmd = Console.ReadLine();
            }

            
        }
    }
}

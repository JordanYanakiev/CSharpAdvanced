/*Play around with a stack. You will be given an integer N representing the number of elements to push into the stack, an integer S representing the number of elements to pop from the stack, and finally an integer X, an element that you should look for in the stack. If it’s found, print "true" on the console. If it isn't, print the smallest element currently present in the stack. If there are no elements in the sequence, print 0 on the console.
Input
    • On the first line, you will be given N, S, and X, separated by a single space
    • On the next line, you will be given N number of integers
Output
    • On a single line print either true if X is present in the stack, otherwise print the smallest element in the stack. If the stack is empty, print 0 */





using System;
using System.Collections;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberOfElements = inputNumbers[0];
            int elementsToPop = inputNumbers[1];
            int numberToSearchFor = inputNumbers[2];
            int[] inputNumbersToAdd = new int[numberOfElements];

            inputNumbersToAdd = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack stack = new Stack(inputNumbersToAdd);

            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(numberToSearchFor))
            {
                Console.WriteLine("true");
            } else if (!stack.Contains(numberToSearchFor) && stack.Count > 0)
            {
                int temp = 0;
                int temp2 = int.MaxValue;

                while (stack.Count > 0)
                {
                    temp = (int)stack.Pop();

                    if (temp < temp2)
                    {
                        temp2 = temp;
                    }
                }
                Console.WriteLine(temp2);
            } else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }

        }
    }
}

/*
 Play around with a queue. You will be given an integer N representing the number of elements to enqueue (add), an integer S representing the number of elements to dequeue (remove) from the queue, and finally an integer X, an element that you should look for in the queue. If it is, print true on the console. If it’s not printed the smallest element is currently present in the queue. If there are no elements in the sequence, print 0 on the console.
 
 
 */



using System;
using System.Collections;
using System.Linq;

namespace _02.BasicQueueOperations
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

            Queue stack = new Queue(inputNumbersToAdd);

            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Dequeue();
            }

            if (stack.Contains(numberToSearchFor))
            {
                Console.WriteLine("true");
            }
            else if (!stack.Contains(numberToSearchFor) && stack.Count > 0)
            {
                int temp = 0;
                int temp2 = int.MaxValue;

                while (stack.Count > 0)
                {
                    temp = (int)stack.Dequeue();

                    if (temp < temp2)
                    {
                        temp2 = temp;
                    }
                }
                Console.WriteLine(temp2);
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }

        }
    }
}

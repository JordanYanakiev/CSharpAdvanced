/*
 
You have an empty sequence, and you will be given N queries. Each query is one of these three types:
1 x – Push the element x into the stack.
2 – Delete the element present at the top of the stack.
3 – Print the maximum element in the stack.
4 – Print the minimum element in the stack.
After you go through all of the queries, print the stack in the following format:
"{n}, {n1}, {n2} …, {nn}"
 
 */



using System;
using System.Collections;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int maxNumber = 1;
            int minNumber = 109;
            int temp1 = 0;
            int temp2 = 0;
            int command1 = 0;
            int command2 = 0;

            int[] inputArr = new int[0];

            Stack stack = new Stack();

            for (int i = 1; i <= numberOfInputs; i++)
            {

                inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (inputArr.Length > 1)
                {
                    command1 = inputArr[0];
                    command2 = inputArr[1];

                    if (command1 == 1)
                    {
                        stack.Push(command2);

                        if (command2 > maxNumber)
                        {
                            maxNumber = command2;
                        }

                        if (command2 < minNumber)
                        {
                            minNumber = command2;
                        }
                    }
                } 
                else if (inputArr.Length == 1)
                {
                    command1 = inputArr[0];

                    if (command1 == 2)
                    {
                        if (stack.Count > 0)
                        {
                            int tem = (int)stack.Pop();
                            if (tem >= maxNumber && (stack.Count == 0 || !stack.Contains(tem)))
                            {
                                maxNumber = 1;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (command1 == 3)
                    {
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(maxNumber);
                        }
                        else { continue;  }
                    }
                    else if (command1 == 4)
                    {
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(minNumber);
                        }
                        else { continue;  }
                    }
                }


            }

            int counter = 0;
            int[] tempArr = new int[stack.Count]; 

            while (stack.Count > 0)
            {
                tempArr[counter] = (int)stack.Pop();
                counter++;
            }

            Console.Write(string.Join(", ", tempArr));

        }
    }
}

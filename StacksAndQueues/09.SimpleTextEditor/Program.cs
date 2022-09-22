/*
 You are given an empty text. Your task is to implement 4 commands related to manipulating the text
    • 1 someString - appends someString to the end of the text
    • 2 count - erases the last count elements from the text
    • 3 index - returns the element at position index from the text
    • 4 - undoes the last not undone command of type 1 / 2 and returns the text to the state before that operation
 */



using System;
using System.Collections.Generic;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            Stack<string> memory = new Stack<string>();
            StringBuilder stringBuilt = new StringBuilder();
            memory.Push(string.Join(" ", stringBuilt));

            for (int i = 0; i < numberOfOperations; i++)
            {

                string[] inputStrArr = Console.ReadLine().Split();
                int cmdToken01 = int.Parse(inputStrArr[0]);

                switch (cmdToken01)
                {
                    case 1:
                        {
                            string stringToAppend = inputStrArr[1];
                            stringBuilt.Append(stringToAppend);
                            memory.Push(stringBuilt.ToString());
                            break;
                        }

                    case 2:
                        {
                            int count = int.Parse(inputStrArr[1]);
                            stringBuilt.Remove(stringBuilt.Length - count, count);
                            memory.Push(stringBuilt.ToString());
                            break;
                        }

                    case 3:
                        {
                            int indexToRetrieve = int.Parse(inputStrArr[1]) - 1;
                            string symbolToShow = null;

                            if (indexToRetrieve >= 0 && indexToRetrieve < stringBuilt.Length)
                            {
                                symbolToShow = stringBuilt[indexToRetrieve].ToString();
                            }
                            Console.WriteLine(symbolToShow);

                            break;
                        }

                    case 4:
                        {
                            memory.Pop();
                            string undo = memory.Peek();
                            stringBuilt.Remove(0, stringBuilt.Length);
                            stringBuilt.Append(undo);

                            break;
                        }
                }
            }

        }
    }
}

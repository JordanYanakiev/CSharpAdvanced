using System;
using System.Collections.Generic;

namespace _08.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] parenthesesArr = Console.ReadLine().ToCharArray();
            Stack<char> charStack = new Stack<char>();
            bool parenthesesAreSymetrical = false;

            for (int i = 0; i < parenthesesArr.Length; i++)
            {
                if (i < parenthesesArr.Length / 2)
                {
                    charStack.Push(parenthesesArr[i]);
                }

                if (i > (parenthesesArr.Length / 2)-1)
                {
                    char symbol = charStack.Pop();
                    int asciiLeftParentheses = (int)symbol;
                    char symbolFromArray = parenthesesArr[i];
                    int asciiRightParentheses = (int)symbolFromArray;

                    if (asciiLeftParentheses == asciiRightParentheses - 1 || asciiLeftParentheses == asciiRightParentheses - 2 || (asciiLeftParentheses == 32 && asciiRightParentheses == 32))
                    {
                        parenthesesAreSymetrical = true;
                    }
                    else if (asciiLeftParentheses != asciiRightParentheses - 1 || asciiLeftParentheses != asciiRightParentheses - 2 || (asciiLeftParentheses != 32 && asciiRightParentheses != 32))
                    {
                        parenthesesAreSymetrical = false;
                        Console.WriteLine("NO");
                        break;
                    }
                }
            }

            if (parenthesesAreSymetrical)
            {
                Console.WriteLine("YES");
            }
            

        }
    }
}

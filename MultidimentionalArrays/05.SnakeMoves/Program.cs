using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraySizes = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();
            char[] charArr = Console.ReadLine().ToCharArray();

            char[,] charMatrix = new char[arraySizes[0], arraySizes[1]];
            int charsCounter = 0;

            for (int row = 0; row < arraySizes[0]; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < arraySizes[1]; col++)
                    {
                        charMatrix[row, col] = charArr[charsCounter];
                        charsCounter++;

                        if (charsCounter == charArr.Length)
                        {
                            charsCounter = 0;
                        }
                    }
                }
                else
                {
                    for (int col = arraySizes[1] - 1; col >= 0; col--)
                    {
                        charMatrix[row, col] = charArr[charsCounter];
                        charsCounter++;

                        if (charsCounter == charArr.Length)
                        {
                            charsCounter = 0;
                        }
                    }
                }

            }
            
            for (int row = 0; row < arraySizes[0]; row++)
            {
                for (int col = 0; col < arraySizes[1]; col++)
                {
                    Console.Write(charMatrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

/*
    Create a program that finds the difference between the sums of the square matrix diagonals (absolute
    value).
 */

using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            int backWardsCounter = size - 1;

            for (int rows = 0; rows < size; rows++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int cols = 0; cols < size; cols++)
                {
                    matrix[rows, cols] = numbers[cols];
                }
            }

            for (int rows = 0; rows < size; rows++)
            {
                for (int cols = 0; cols < size; cols++)
                {
                    if (rows == cols)
                    {
                        primaryDiagonal += matrix[rows, cols];
                    }

                    if (cols == backWardsCounter)
                    {
                        secondaryDiagonal += matrix[rows, cols];
                    }
                }

                backWardsCounter--;
            }

            int absoluteSum = Math.Abs(primaryDiagonal - secondaryDiagonal);
            Console.WriteLine(absoluteSum);
        }
    }
}

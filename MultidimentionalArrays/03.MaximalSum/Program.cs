using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];
            int maxValueInMatrix = int.MinValue;
            int maxValueRowIndex = 0;
            int maxValueColIndex = 0;

            for (int rows = 0; rows < matrixSize[0]; rows++)
            {
                int[] input = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();

                for (int cols = 0; cols < matrixSize[1]; cols++)
                {
                    matrix[rows, cols] = input[cols];
                }
            }
            
            for (int rows = 0; rows < matrixSize[0] - 2; rows++)
            {
                for (int cols = 0; cols < matrixSize[1] - 2; cols++)
                {
                    int tempValue = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows, cols + 2] +
                        matrix[rows + 1, cols] + matrix[rows + 1, cols + 1] + matrix[rows + 1, cols + 2] +
                        matrix[rows + 2, cols] + matrix[rows + 2, cols + 1] + matrix[rows + 2, cols + 2];

                    if (tempValue > maxValueInMatrix)
                    {
                        maxValueInMatrix = tempValue;
                        maxValueRowIndex = rows;
                        maxValueColIndex = cols;
                    }

                }
            }

            Console.WriteLine($"Sum = {maxValueInMatrix}");
            
            for (int rows = maxValueRowIndex; rows < maxValueRowIndex + 3; rows++)
            {
                for (int cols = maxValueColIndex; cols < maxValueColIndex + 3; cols++)
                {
                    Console.Write(matrix[rows, cols] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}

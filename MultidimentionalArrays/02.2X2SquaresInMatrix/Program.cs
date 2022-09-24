using System;
using System.Linq;

namespace _02._2X2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();
            string[,] matrix = new string[matrixSize[0], matrixSize[1]];
            int counter = 0;

            for (int rows = 0; rows < matrixSize[0]; rows++)
            {
                string[] characters = Console.ReadLine().Split().ToArray();

                for (int cols = 0; cols < matrixSize[1]; cols++)
                {
                    matrix[rows, cols] = characters[cols];
                }
            }

            for (int rows = 0; rows < matrixSize[0] - 1; rows++)
            {
                for (int cols = 0; cols < matrixSize[1] - 1; cols++)
                {
                    if (matrix[rows, cols] == matrix[rows, cols + 1] && matrix[rows, cols] == matrix[rows + 1, cols + 1] && matrix[rows, cols] == matrix[rows + 1, cols])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);


        }
    }
}

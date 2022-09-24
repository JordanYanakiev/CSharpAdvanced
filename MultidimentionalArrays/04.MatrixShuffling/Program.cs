using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();
            string[,] matrix = new string[matrixSize[0], matrixSize[1]];
            string[] cmd = new string[] { };
            string mainCommand = null;
            
            for (int row = 0; row < matrixSize[0]; row++)
            {
                string input = Console.ReadLine();

                string[] inputArr =  input.Split().ToArray();

                    for (int col = 0; col < matrixSize[1]; col++)
                    {
                        matrix[row, col] = inputArr[col];
                    }
            }

            cmd = Console.ReadLine().Split().ToArray();
            mainCommand = cmd[0];

            while (mainCommand != "END")
            {
                if (mainCommand != "swap")
                {
                    Console.WriteLine("Invalid input!");
                } 
                else if (mainCommand == "swap")
                {
                    int row1 = int.Parse(cmd[1]);
                    int row1col1 = int.Parse(cmd[2]);
                    int row2 = int.Parse(cmd[3]);
                    int row2col2 = int.Parse(cmd[4]);

                    if (row1 > matrix.GetLength(0) || row1col1 > matrix.GetLength(0) ||
                        row2 > matrix.GetLength(1) || row2col2 > matrix.GetLength(1) ||
                        row1 < 0 || row1col1 < 0 || row2 < 0 || row2col2 < 0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else 
                    {
                        string number1 = matrix[row1, row1col1];
                        string number2 = matrix[row2, row2col2];
                        string midNum = number1;
                        matrix[row1, row1col1] = matrix[row2, row2col2];
                        matrix[row2, row2col2] = number1;

                        for (int roww = 0; roww < matrix.GetLength(0); roww++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[roww, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }

                cmd = Console.ReadLine().Split().ToArray();
                mainCommand = cmd[0];
            }
        }
    }
}

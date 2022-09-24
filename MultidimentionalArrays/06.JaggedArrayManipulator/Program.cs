using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[rows][];

            for (int rows2 = 0; rows2 < rows; rows2++)
            {
                double[] newLine = Console.ReadLine().Split().Select(n => double.Parse(n)).ToArray();
                jaggedArray[rows2] = newLine;
            }

            for (int rows2 = 0; rows2 < rows - 1; rows2++)
            {
                /*
                 * If a row and the one below it have equal length, multiply each element in both of them
                 * by 2, otherwise - divide by 2
                 */
                if (jaggedArray[rows2].Length == jaggedArray[rows2 + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[rows2].Length; col++)
                    {
                        jaggedArray[rows2][col] *= 2;
                        jaggedArray[rows2+1][col] *= 2;
                    }
                }
                else if (jaggedArray[rows2].Length != jaggedArray[rows2 + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[rows2].Length; col++)
                    {
                        jaggedArray[rows2][col] /= 2;
                    }
                    for (int col = 0; col < jaggedArray[rows2+1].Length; col++)
                    {
                        jaggedArray[rows2+1][col] /= 2;
                    }
                }
            }

            string[] cmd = Console.ReadLine().Split();
            string command = cmd[0];

            while (command != "End")
            {
                switch (command)
                {
                    case "Add":
                        {
                            int row = int.Parse(cmd[1]);
                            int col = int.Parse(cmd[2]);
                            double value = double.Parse(cmd[3]);
                            if (row >= 0 && row < jaggedArray.Length && col >= 0 &&
                                col < jaggedArray[row].Length)
                            {
                                jaggedArray[row][col] += value;
                            }
                            break;
                        }
                    case "Subtract":
                        {
                            int row = int.Parse(cmd[1]);
                            int col = int.Parse(cmd[2]);
                            double value = double.Parse(cmd[3]);

                            if (row >= 0 && row < jaggedArray.Length && col >= 0 &&
                                col < jaggedArray[row].Length)
                            {
                                jaggedArray[row][col] -= value;
                            }
                            break;
                        }
                }

                cmd = Console.ReadLine().Split();
                command = cmd[0];
            }



            for (int rows2 = 0; rows2 < rows; rows2++)
            {
                /*
                 * If a row and the one below it have equal length, multiply each element in both of them
                 * by 2, otherwise - divide by 2
                 */
                
                    for (int col = 0; col < jaggedArray[rows2].Length; col++)
                    {
                      Console.Write(jaggedArray[rows2][col] + " ");
                    }
                Console.WriteLine();
                
            }

        }
    }
}

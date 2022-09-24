using System;
using System.Linq;

namespace _07.KnightsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] gameField = new char[size, size];
            int removedKnights = 0;

            //Populate game board
            for (int row = 0; row < size; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    gameField[row, col] = input[col];
                }
            }


            if (size < 3)
            {
                //Game Over
                Console.WriteLine("0");
                return;
            }
            

            while (true)
            {
                int countKnights = 0;
                int attackedKnightsCount = 0;
                int colMaxMoves = 0;
                int rowMaxMoves = 0;
                
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (gameField[row, col] == 'K')
                        {
                            attackedKnightsCount = CheckForOtherKnightsFromThisPosition(row, col, size, gameField);
                            //Console.WriteLine(countKnights + " " + gameField[row, col]);

                            if (attackedKnightsCount > countKnights)
                            {
                                countKnights = attackedKnightsCount;
                                colMaxMoves = col;
                                rowMaxMoves = row;
                                //gameField[rowMaxMoves, colMaxMoves] = 'o';
                            }
                        }
                    }
                }

                if (countKnights == 0)
                {
                    break;
                }
                else
                {
                    gameField[rowMaxMoves, colMaxMoves] = 'o';
                    removedKnights++;
                }
            }

            Console.WriteLine(removedKnights);









            ////Draw Matrix
            //for (int row = 0; row < size; row++)
            //{
            //    for (int col = 0; col < size; col++)
            //    {
            //        Console.Write(gameField[row, col]);
            //    }
            //    Console.WriteLine();
            //}
        }

        public static int CheckForOtherKnightsFromThisPosition(int row, int col, int size, char[,] gameField)
        {
            int numberOfValidMoves = 0;

            //lefft down
            if (IsValidPosition(row - 1, col - 2, size, gameField))
            {
                if (gameField[row - 1, col - 2] == 'K')
                {
                    numberOfValidMoves++;
                }
            }

            //left up
            if (IsValidPosition(row + 1, col - 2, size, gameField))
            {
                if (gameField[row + 1, col - 2] == 'K')
                {
                    numberOfValidMoves++;
                }
            }

            //up left
            if (IsValidPosition(row + 2, col - 1, size, gameField))
            {
                if (gameField[row + 2, col - 1] == 'K')
                {
                    numberOfValidMoves++;
                }
            }

            //up right
            if (IsValidPosition(row + 2, col + 1, size, gameField))
            {
                if (gameField[row + 2, col + 1] == 'K')
                {
                    numberOfValidMoves++;
                }
            }

            //right up
            if (IsValidPosition(row + 1, col + 2, size, gameField))
            {
                if (gameField[row + 1, col + 2] == 'K')
                {
                    numberOfValidMoves++;
                }
            }

            //right down
            if (IsValidPosition(row - 1, col + 2, size, gameField))
            {
                if (gameField[row - 1, col + 2] == 'K')
                {
                    numberOfValidMoves++;
                }
            }

            //down right
            if (IsValidPosition(row - 2, col + 1, size, gameField))
            {
                if (gameField[row - 2, col + 1] == 'K')
                {
                    numberOfValidMoves++;
                }
            }

            //down left
            if (IsValidPosition(row - 2, col - 1, size, gameField))
            {
                if (gameField[row - 2, col - 1] == 'K')
                {
                    numberOfValidMoves++;
                }
            }

            return numberOfValidMoves;
        }

        public static bool IsValidPosition(int row, int col, int size, char[,] matrix)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }
    }
}

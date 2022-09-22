/*
 You own a fashion boutique and you receive a delivery once a month in a huge box, which is full of clothes. You have to arrange them in your store, so you take the box and start from the last piece of clothing on the top of the pile to the first one at the bottom. Use a stack for this purpose. Each piece of clothing has its value (an integer). You have to sum their values, while you take them out of the box. You will be given an integer representing the capacity of a rack. While the sum of the clothes is less than the capacity, keep summing them. If the sum becomes equal to the capacity you have to take a new rack for the next clothes if there are any left in the box. If it becomes greater than the capacity, don't add the piece of clothing to the current rack and take a new one. In the end, print how many racks you have used to hang all of the clothes.
 */


using System;
using System.Collections;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack crateWithClothes = new Stack(clothesInBox);
            int rackCapacity = int.Parse(Console.ReadLine());
            int rackCounter = 0;
            int racksNeeded = 1;
            int tempNum = 0;


            while (crateWithClothes.Count > 0)
            {
                rackCounter += (int)crateWithClothes.Pop();

                if (crateWithClothes.Count > 0)
                {
                    tempNum = (int)crateWithClothes.Peek();
                }
                else if (crateWithClothes.Count == 0)
                {
                    tempNum = 0;
                }

                if (rackCounter + tempNum > rackCapacity)
                {
                    racksNeeded++;
                    rackCounter = 0;
                }


            }

            Console.WriteLine(racksNeeded);
        }
    }
}

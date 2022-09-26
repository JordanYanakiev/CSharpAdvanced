using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfEntries = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < NumberOfEntries; i++)
            {
                string[] color = Console.ReadLine().Split(" -> ");
                string[] clothes = color[1].Split(",");

                if (!wardrobe.ContainsKey(color[0]))
                {
                    wardrobe.Add(color[0], new Dictionary<string, int>());

                    for (int j = 0; j < clothes.Length; j++) 
                    {
                        if (!wardrobe[color[0]].ContainsKey(clothes[j]))
                        {
                            wardrobe[color[0]].Add(clothes[j], 1);
                        }
                        else if (wardrobe[color[0]].ContainsKey(clothes[j]))
                        {
                            wardrobe[color[0]][clothes[j]]++;
                        }
                    }
                }
                else if (wardrobe.ContainsKey(color[0]))
                {
                    for (int l = 0; l < clothes.Length; l++) 
                    {
                        if (!wardrobe[color[0]].ContainsKey(clothes[l]))
                        {
                            wardrobe[color[0]].Add(clothes[l], 1);
                        }
                        else if (wardrobe[color[0]].ContainsKey(clothes[l]))
                        {
                            wardrobe[color[0]][clothes[l]]++;
                        }
                    }
                }
            }

            string[] clothesToSearchFor = Console.ReadLine().Split();

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var clothing in color.Value)
                {
                    if (color.Key == clothesToSearchFor[0] && clothing.Key == clothesToSearchFor[1])
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                    }
                }
            }
        }
    }
}

/*
 Write a program that keeps track of a song's queue. The first song that is put in the queue, should be the first that gets played. A song cannot be added if it is currently in the queue.
You will be given a sequence of songs, separated by a comma and a single space. After that, you will be given commands until there are no songs enqueued. When there are no more songs in the queue print "No more songs!" and stop the program.
The possible commands are:
    • "Play" - plays a song (removes it from the queue)
    • "Add {song}" - adds the song to the queue if it isn’t contained already, otherwise print "{song} is already contained!"
    • "Show" - prints all songs in the queue separated by a comma and a white space (start from the first song in the queue to the last)
 */


using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commandString = Console.ReadLine().Split(", ").ToArray();
            Queue<string> songsPlayList = new Queue<string>(commandString);
            string command1 = null;
            string command2 = null;

            while (songsPlayList.Count > 0)
            {
                commandString = Console.ReadLine().Split(" ").ToArray();

                if (commandString.Length > 1)
                {
                    command1 = commandString[0];
                    string delStr = command1;
                    commandString = commandString.Where(val => val != delStr).ToArray();
                    command2 = string.Join(" ", commandString);
                }
                else
                {
                    command1 = commandString[0];
                }

                if (command1 == "Add")
                {
                    if (!songsPlayList.Contains(command2))
                    {
                        songsPlayList.Enqueue(command2);
                    }
                    else if (songsPlayList.Contains(command2))
                    {
                        Console.WriteLine($"{command2} is already contained!"); 
                    }
                }
                else if (command1 == "Play")
                {
                    if (songsPlayList.Count > 0)
                    {
                        songsPlayList.Dequeue();
                    }
                }
                else if (command1 == "Show")
                {
                    Console.WriteLine(String.Join(", ", songsPlayList));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}

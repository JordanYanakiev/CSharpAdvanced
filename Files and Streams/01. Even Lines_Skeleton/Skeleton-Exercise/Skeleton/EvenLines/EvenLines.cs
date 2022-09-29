


namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            string readLain = string.Empty;
            StreamReader sr = new StreamReader(inputFilePath);
            int count = 0;

            while (readLain != null)
            {
                readLain = sr.ReadLine();
                string reverse = Reversewords(readLain);
                string replacedSymbols = ReplaceSymbols(reverse);
                

                if (count % 2 == 0)
                {
                    Console.WriteLine(replacedSymbols);
                }

                count++;
            }

            return readLain;
        }

        private static string ReplaceSymbols(string reverse)
        {
            string[] symbolsToSwitch = { "-", ",", ".", "!", "?"};

            foreach (var symbol in symbolsToSwitch)
            {
                reverse =  reverse.Replace(symbol, "@");
            }

            return reverse;
        }

        public static string Reversewords(string readedLine)
        {
            string[] strToReverse = readedLine.Split(" ").Reverse().ToArray();
            //Console.WriteLine(strToReverse);
            return string.Join(" ", strToReverse);
        }
    }
}

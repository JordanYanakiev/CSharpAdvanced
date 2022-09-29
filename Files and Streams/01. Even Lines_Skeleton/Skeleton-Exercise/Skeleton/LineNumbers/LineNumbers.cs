namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string readLine = string.Empty;
            StreamReader sr = new StreamReader(inputFilePath);
            //FileStream sWrt = new FileStream(outputFilePath, FileMode.Create());
            StringBuilder sb = new StringBuilder();
            int counter = 1; 

            while (readLine != null)
            {
                readLine = sr.ReadLine();
                int countSymbols = CountSymbols(readLine);
                int countLetters = CountLetters(readLine);

                if (readLine != null)
                {
                    string lineNumber = $"Line {counter}: " + readLine + $" ({countLetters})({countSymbols}) ";
                    sb.AppendLine(lineNumber);
                    //Console.WriteLine(lineNumber);
                }
                counter++;
            }

            File.WriteAllText(outputFilePath, sb.ToString());

        }

        private static int CountSymbols(string readLine)
        {
            int symbolsCount = 0;

            if (readLine != null)
            {
                for (int i = 0; i < readLine.Length; i++)
                {
                    if (readLine[i] == '?' || readLine[i] == '!' || readLine[i] == '-' || readLine[i] == '.'
                        || readLine[i] == ',' || readLine[i] == '\'')
                    {
                        symbolsCount++;
                    }
                }
            }

            return symbolsCount;
        }
        
        private static int CountLetters(string readLine)
        {
            int lettersCount = 0;

            if (readLine != null)
            {
                for (int i = 0; i < readLine.Length; i++)
                {
                    if (char.IsLetter(readLine[i]))
                    {
                        lettersCount++;
                    }
                }
            }

            return lettersCount;
        }
    }
}

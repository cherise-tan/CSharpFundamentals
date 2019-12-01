using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"d:\demo.txt";

            var fileData = File.ReadAllText(path).Split("\n");

            Console.WriteLine("Number of Words: " + fileData.Length);

            var longestWord = "";
            foreach (var line in fileData)
            {
                if (line.Length > longestWord.Length)
                {
                    longestWord = line;
                }
            }

            Console.WriteLine(longestWord);
        }
    }
}

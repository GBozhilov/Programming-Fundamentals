using System;
using System.Linq;
using System.IO;

public class IndexOfLetters
{
    public static void Main()
    {
        File.Delete("output.txt");

        string[] inputLines = File.ReadAllLines("input.txt")
            .Select(line => line.ToLower())
            .ToArray();

        char[] alphabet = new char[26];

        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)(i + 97);
        }

        foreach (var line in inputLines)
        {
            char[] symbols = line.ToCharArray();

            foreach (var symbol in symbols)
            {
                int index = Array.IndexOf(alphabet, symbol);

                File.AppendAllText("output.txt", $"{symbol} -> {index}" + Environment.NewLine);
            }

            File.AppendAllText("output.txt", Environment.NewLine);
        }
    }
}
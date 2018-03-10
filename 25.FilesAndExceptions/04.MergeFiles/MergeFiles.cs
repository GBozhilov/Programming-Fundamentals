using System;
using System.IO;

public class MergeFiles
{
    public static void Main()
    {
        string[] firstFileLines = File.ReadAllLines("../../input1.txt");
        string[] secondFileLines = File.ReadAllLines("../../input2.txt");

        string[] outputFileLines = new string[firstFileLines.Length];

        for (int i = 0; i < firstFileLines.Length; i++)
        {
            outputFileLines[i] = $"{firstFileLines[i] + Environment.NewLine}" +
                $"{secondFileLines[i]}";
        }

        File.WriteAllLines("../../output.txt", outputFileLines);
    }
}
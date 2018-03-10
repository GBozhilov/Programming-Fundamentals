using System;
using System.IO;

public class OddLinesOtherWay
{
    public static void Main()
    {
        var inputLines = File.ReadAllLines("input.txt");

        for (int i = 1; i < inputLines.Length; i += 2)
        {
            File.AppendAllText("output.txt", inputLines[i] + Environment.NewLine);
        }
    }
}
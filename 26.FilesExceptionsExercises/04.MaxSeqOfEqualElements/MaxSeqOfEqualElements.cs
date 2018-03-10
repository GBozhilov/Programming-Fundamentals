using System;
using System.IO;
using System.Linq;

public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        File.Delete("output.txt");

        var lines = File.ReadAllLines("input.txt");

        foreach (var line in lines)
        {
            var numbers = line
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int start = 0, bestStart = 0, length = 1, bestLength = 1;

            for (int pos = 1; pos < numbers.Length; pos++)
            {
                var currentNum = numbers[pos];
                var previousNum = numbers[pos - 1];

                if (currentNum.Equals(previousNum))
                {
                    length++;
                }
                else
                {
                    length = 1;
                    start = pos;
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                File.AppendAllText("output.txt", $"{numbers[i]} ");
            }

            File.AppendAllText("output.txt", Environment.NewLine);
        }
    }
}
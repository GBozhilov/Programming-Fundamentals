using System;
using System.Linq;
using System.IO;

public class MostFrequentNumber
{
    public static void Main()
    {
        File.Delete("output.txt");

        string[] inputLines = File.ReadAllLines("input.txt");

        for (int i = 0; i < inputLines.Length; i++)
        {
            int[] numbers = inputLines[i]
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int bestCount = 0;
            int bestNum = 0;

            for (int j = 0; j < numbers.Length; j++)
            {
                int count = 0;
                int currentNum = numbers[j];

                for (int k = 0; k < numbers.Length; k++)
                {
                    int checkedNum = numbers[k];

                    if (currentNum == checkedNum)
                    {
                        count++;
                    }
                }

                if (count > bestCount)
                {
                    bestCount = count;
                    bestNum = currentNum;
                }
            }

            File.AppendAllText("output.txt", bestNum.ToString() + Environment.NewLine);
        }
    }
}
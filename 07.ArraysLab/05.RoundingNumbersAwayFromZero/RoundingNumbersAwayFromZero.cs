using System;

public class RoundingNumbersAwayFromZero
{
    public static void Main()
    {
        string sequence = Console.ReadLine();

        double[] items = ReadNumbers(sequence);

        int[] roundedNums = RoundNumbers(items);

        PrintArrays(items, roundedNums);
    }

    static double[] ReadNumbers(string sequence)
    {
        string[] valuesStr = sequence.Split(' ');

        double[] items = new double[valuesStr.Length];

        for (int index = 0; index < valuesStr.Length; index++)
            items[index] = double.Parse(valuesStr[index]);

        return items;
    }

    static int[] RoundNumbers(double[] items)
    {
        int[] roundedNums = new int[items.Length];

        for (int index = 0; index < items.Length; index++)
            roundedNums[index] = (int)Math.Round(items[index],
                MidpointRounding.AwayFromZero);

        return roundedNums;
    }

    static void PrintArrays(double[] items, int[] roundedNums)
    {
        for (int index = 0; index < items.Length; index++)
            Console.WriteLine($"{items[index]} => {roundedNums[index]}");
    }
}
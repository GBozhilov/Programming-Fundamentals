using System;

public class FoldAndSum
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        int[] numbers = new int[input.Length]; // 4 * k

        for (int i = 0; i < input.Length; i++)
            numbers[i] = int.Parse(input[i]);

        int k = input.Length / 4;
        int[] upperArr = new int[2 * k];
        int[] lowerArr = new int[2 * k];

        for (int i = 0; i < k; i++)
            upperArr[i] = numbers[k - 1 - i];

        for (int i = 0; i < k; i++)
            upperArr[i + k] = numbers[4 * k - 1 - i];

        for (int i = 0; i < 2 * k; i++)
            lowerArr[i] = numbers[i + k];

        int[] sumArr = new int[2 * k];

        for (int i = 0; i < 2 * k; i++)
            sumArr[i] = upperArr[i] + lowerArr[i];

        Console.WriteLine(string.Join(" ", sumArr));
    }
}
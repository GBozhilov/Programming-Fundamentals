using System;

public class ReverseArrayOfStrings
{
    public static void Main()
    {
        string sequence = Console.ReadLine();

        string[] items = sequence.Split(' ');

        string[] reversed = new string[items.Length];

        for (int i = 0; i < items.Length; i++)
            reversed[i] = items[items.Length - i - 1];

        Console.WriteLine(string.Join(" ", reversed));
    }
}
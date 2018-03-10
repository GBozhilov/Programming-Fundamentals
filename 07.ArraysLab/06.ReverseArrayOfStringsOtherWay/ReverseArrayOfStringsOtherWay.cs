using System;
using System.Linq;

public class ReverseArrayOfStringsOtherWay
{
    public static void Main()
    {
        string[] sequence = Console.ReadLine().Split(' ');

        for (int i = 0; i < sequence.Length / 2; i++)
        {
            int j = sequence.Length - i - 1;
            SwapElements(sequence, i, j);
        }

        Console.WriteLine(string.Join(" ", sequence));
    }

    static void SwapElements(string[] sequence, int i, int j)
    {
        string oldElement = sequence[i];
        sequence[i] = sequence[j];
        sequence[j] = oldElement;
    }
}
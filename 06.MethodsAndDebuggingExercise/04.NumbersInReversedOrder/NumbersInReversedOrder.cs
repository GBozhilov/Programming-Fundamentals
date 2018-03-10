using System;

public class NumbersInReversedOrder
{
    public static void Main()
    {
        string numberStr = Console.ReadLine();

        PrintReversedString(numberStr);
    }

    static void PrintReversedString(string numberStr)
    {
        for (int index = numberStr.Length - 1; index >= 0; index--)
        {
            Console.Write(numberStr[index]);
        }

        Console.WriteLine();
    }
}
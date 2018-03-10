using System;
using System.Linq;

public class SequenceOfCommands
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string commandLine = Console.ReadLine();

        while (!commandLine.Equals("stop"))
        {
            string[] stringParams = commandLine.Split(ArgumentsDelimiter);
            long[] args = new long[2];

            if (stringParams[0].Equals("add") || stringParams[0].Equals("subtract") || stringParams[0].Equals("multiply"))
            {
                args[0] = long.Parse(stringParams[1]);
                args[1] = long.Parse(stringParams[2]);
            }

            PerformAction(array, stringParams[0], args);

            PrintArray(array);

            commandLine = Console.ReadLine();
        }
    }

    public static void PerformAction(long[] arr, string action, long[] args)
    {
        long pos = args[0];
        long value = args[1];

        switch (action)
        {
            case "multiply":
                arr[pos - 1] *= value;
                break;
            case "add":
                arr[pos - 1] += value;
                break;
            case "subtract":
                arr[pos - 1] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(arr);
                break;
            case "rshift":
                ArrayShiftRight(arr);
                break;
        }
    }

    public static void ArrayShiftRight(long[] arr)
    {
        long lastElement = arr[arr.Length - 1];

        for (int i = arr.Length - 1; i >= 1; i--)
        {
            arr[i] = arr[i - 1];
        }

        arr[0] = lastElement;
    }

    public static void ArrayShiftLeft(long[] arr)
    {
        long firstElement = arr[0];

        for (int i = 0; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1];
        }

        arr[arr.Length - 1] = firstElement;
    }

    public static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }
}

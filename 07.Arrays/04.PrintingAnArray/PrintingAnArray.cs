using System;

public class PrintingAnArray
{
    public static void Main()
    {
        string[] array = { "one", "two", "three", "four" };

        for (int index = 0; index < array.Length; index++)
        {
            Console.WriteLine($"Element[{index}] = {array[index]}");
        }
    }
}
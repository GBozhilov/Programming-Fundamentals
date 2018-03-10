using System;

public class PrintPartOfASCIITable
{
    public static void Main()
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());

        for (int index = startNumber; index <= endNumber; index++)
        {
            Console.Write($"{(char)index} ");
        }

        Console.WriteLine();
    }
}
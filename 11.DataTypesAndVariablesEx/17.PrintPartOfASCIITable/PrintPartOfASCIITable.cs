using System;

public class PrintPartOfASCIITable
{
    public static void Main()
    {
        var startIndex = int.Parse(Console.ReadLine());
        var endIndex = int.Parse(Console.ReadLine());

        for (int index = startIndex; index <= endIndex; index++)
        {
            if (index != endIndex)
            {
                Console.Write((char)index + " ");
                continue;
            }

            Console.WriteLine((char)index);
        }
    }
}
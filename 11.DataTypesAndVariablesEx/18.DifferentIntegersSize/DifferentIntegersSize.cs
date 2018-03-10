using System;

public class DifferentIntegersSize
{
    public static void Main()
    {
        var numberStr = Console.ReadLine();

        try
        {
            var number = long.Parse(numberStr);

            Console.WriteLine($"{number} can fit in:");
            CheckType(number);
        }
        catch (Exception)
        {
            Console.WriteLine($"{numberStr} can't fit in any type");
        }
    }

    public static void CheckType(long number)
    {
        if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
        {
            Console.WriteLine("* sbyte");
        }

        if (number >= byte.MinValue && number <= byte.MaxValue)
        {
            Console.WriteLine("* byte");
        }

        if (number >= short.MinValue && number <= short.MaxValue)
        {
            Console.WriteLine("* short");
        }

        if (number >= ushort.MinValue && number <= ushort.MaxValue)
        {
            Console.WriteLine("* ushort");
        }

        if (number >= int.MinValue && number <= int.MaxValue)
        {
            Console.WriteLine("* int");
        }

        if (number >= uint.MinValue && number <= uint.MaxValue)
        {
            Console.WriteLine("* uint");
        }

        if (number >= long.MinValue && number <= long.MaxValue)
        {
            Console.WriteLine("* long");
        }
    }
}
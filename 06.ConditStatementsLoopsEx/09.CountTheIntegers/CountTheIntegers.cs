using System;

public class CountTheIntegers
{
    public static void Main()
    {
        var integersCount = 0;

        while (true)
        {
            var input = Console.ReadLine();

            var number = 0;

            if (!int.TryParse(input, out number))
            {
                break;
            }

            integersCount++;
        }

        Console.WriteLine(integersCount);
    }
}
using System;

public class MagicLetter
{
    public static void Main()
    {
        var firstLetter = Console.ReadLine()[0];
        var secondLetter = Console.ReadLine()[0];
        var ignoredLetter = Console.ReadLine()[0];

        for (char i = firstLetter; i <= secondLetter; i++)
        {
            for (char j = firstLetter; j <= secondLetter; j++)
            {
                for (char k = firstLetter; k <= secondLetter; k++)
                {
                    var resultString = $"{i}{j}{k} ";

                    if (!resultString.Contains(ignoredLetter.ToString()))
                    {
                        Console.Write(resultString);
                    }

                }
            }
        }

        Console.WriteLine();
    }
}
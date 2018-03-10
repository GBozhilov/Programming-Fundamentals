using System;

public class StringConcatenation
{
    public static void Main()
    {
        var delimiter = Console.ReadLine()[0];
        var evenOddParity = Console.ReadLine() == "even" ? 0 : 1;
        var stringsCount = int.Parse(Console.ReadLine());

        var concatenation = string.Empty;

        for (int i = 1; i <= stringsCount; i++)
        {
            var currentText = Console.ReadLine();

            if (i % 2 == evenOddParity)
            {
                concatenation += currentText + delimiter;
            }
        }

        concatenation = concatenation
            .Remove(concatenation.Length - 1);

        Console.WriteLine(concatenation);
    }
}
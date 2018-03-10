using System;

public class DNASequencesOtherWay
{
    public static void Main()
    {
        var matchSum = int.Parse(Console.ReadLine());

        var printsCount = 0;

        for (int firstLetter = 1; firstLetter <= 4; firstLetter++)
        {
            for (int secondLetter = 1; secondLetter <= 4; secondLetter++)
            {
                for (int thirdLetter = 1; thirdLetter <= 4; thirdLetter++)
                {
                    var resultString = $"{firstLetter}{secondLetter}{thirdLetter}"
                        .Replace('1', 'A')
                        .Replace('2', 'C')
                        .Replace('3', 'G')
                        .Replace('4', 'T');

                    var sum = firstLetter + secondLetter + thirdLetter;
                    resultString = sum >= matchSum ? $"O{resultString}O" : $"X{resultString}X";

                    Console.Write($"{resultString} ");
                    printsCount++;

                    if (printsCount % 4 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
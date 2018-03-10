using System;

public class DNASequences
{
    public static void Main()
    {
        var matchSum = int.Parse(Console.ReadLine());

        var printsCount = 1;

        for (char i = 'A'; i <= 'T'; i++)
        {
            for (char j = 'A'; j <= 'T'; j++)
            {
                for (char k = 'A'; k <= 'T'; k++)
                {
                    var isValidFirstLetter = i == 'A' || i == 'C' || i == 'G' || i == 'T';
                    var isValidSecondLetter = j == 'A' || j == 'C' || j == 'G' || j == 'T';
                    var isValidThirdLetter = k == 'A' || k == 'C' || k == 'G' || k == 'T';

                    if (isValidFirstLetter && isValidSecondLetter && isValidThirdLetter)
                    {
                        var resultString = $"{i}{j}{k}";

                        var sum = GetSum(resultString);

                        resultString = sum >= matchSum ? $"O{resultString}O" : $"X{resultString}X";

                        PrintResult(printsCount, resultString);

                        printsCount++;
                    }
                }
            }
        }
    }

    public static void PrintResult(int printsCount, string resultString)
    {
        if (printsCount % 4 != 0)
        {
            Console.Write($"{resultString} ");
        }
        else
        {
            Console.WriteLine(resultString);
        }
    }

    public static int GetSum(string resultString)
    {
        var sum = 0;

        for (int i = 0; i < resultString.Length; i++)
        {
            var currentLetter = resultString[i];

            switch (currentLetter)
            {
                case 'A':
                    sum += 1;
                    break;
                case 'C':
                    sum += 2;
                    break;
                case 'G':
                    sum += 3;
                    break;
                case 'T':
                    sum += 4;
                    break;
            }
        }

        return sum;
    }
}
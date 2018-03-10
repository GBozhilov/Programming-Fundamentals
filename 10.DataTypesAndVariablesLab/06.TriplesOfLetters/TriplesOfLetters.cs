using System;

public class TriplesOfLetters
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    var firstLetter = (char)('a' + i);
                    var secondLetter = (char)('a' + j);
                    var thirdLetter = (char)('a' + k);

                    var result = "" + firstLetter + secondLetter + thirdLetter;

                    Console.WriteLine(result);
                }
            }
        }
    }
}
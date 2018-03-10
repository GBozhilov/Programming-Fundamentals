using System;

public class TriplesOfLetters
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i1 = 0; i1 < n; i1++)
        {
            for (int i2 = 0; i2 < n; i2++)
            {
                for (int i3 = 0; i3 < n; i3++)
                {
                    char firstLetter = (char)('a' + i1);
                    char secondLetter = (char)('a' + i2);
                    char thirdLetter = (char)('a' + i3);

                    Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                }
            }
        }
    }
}
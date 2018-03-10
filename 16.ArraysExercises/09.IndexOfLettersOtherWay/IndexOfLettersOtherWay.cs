using System;

public class IndexOfLettersOtherWay
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .ToLower();

        var alphabet = new char[26];

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)(97 + i);
        }

        for (int i = 0; i < input.Length; i++)
        {
            var currentLetter = input[i];

            for (int j = 0; j < alphabet.Length; j++)
            {
                var checkedLetter = alphabet[j];

                if (currentLetter.Equals(checkedLetter))
                {
                    Console.WriteLine($"{currentLetter} -> {j}");

                    break;
                }
            }
        }
    }
}
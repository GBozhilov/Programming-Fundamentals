using System;

public class IndexOfLetters
{
    public static void Main()
    {
        string input = Console.ReadLine()
            .ToLower();

        char[] alphabet = new char[26];

        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)(i + 97);
        }

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (input[i] == alphabet[j])
                {
                    Console.WriteLine($"{input[i]} -> {j}");
                    break;
                }
            }
        }

    }
}
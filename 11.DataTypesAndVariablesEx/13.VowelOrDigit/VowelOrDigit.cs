using System;

public class VowelOrDigit
{
    public static void Main()
    {
        var symbol = Console.ReadLine().ToLower()[0];

        if (!char.IsDigit(symbol))
        {
            var isVowel = symbol == 'a' || symbol == 'e' || symbol == 'i' || 
                symbol == 'o' || symbol == 'u' || symbol == 'y';

            Console.WriteLine(isVowel ? "vowel" : "other");

            return;
        }

        Console.WriteLine("digit");
    }
}
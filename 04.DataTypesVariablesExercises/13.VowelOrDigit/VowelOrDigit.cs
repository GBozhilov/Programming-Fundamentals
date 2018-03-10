using System;

public class VowelOrDigit
{
    public static void Main()
    {
        char symbol = char.Parse(Console.ReadLine().ToLower());

        try
        {
            byte digit = byte.Parse(symbol.ToString());
            Console.WriteLine("digit");
        }
        catch (Exception)
        {
            bool isVowel = (symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
                (symbol == 'o') || (symbol == 'u') || (symbol == 'y');

            Console.WriteLine(isVowel ? "vowel" : "other");
        }
    }
}
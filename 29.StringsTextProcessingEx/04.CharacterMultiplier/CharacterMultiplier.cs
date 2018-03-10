using System;
using System.Linq;

public class CharacterMultiplier
{
    public static void Main()
    {
        var words = Console.ReadLine().Split(' ');

        var firstString = words.First();
        var secondString = words.Last();

        var sum = GetSumOfMultipliedCodes(firstString, secondString);

        Console.WriteLine(sum);
    }

    public static long GetSumOfMultipliedCodes(string firstString, string secondString)
    {
        long sum = 0;
        var smallerLength = Math.Min(firstString.Length, secondString.Length);
        var biggerLength = Math.Max(firstString.Length, secondString.Length);

        for (int i = 0; i < smallerLength; i++)
        {
            var firstChar = firstString[i];
            var secondChar = secondString[i];

            var product = firstChar * secondChar;

            sum += product;
        }

        var longerString = firstString.Length > secondString.Length ? firstString : secondString;

        for (int i = smallerLength; i < biggerLength; i++)
        {
            var currentChar = longerString[i];

            sum += currentChar;
        }

        return sum;
    }
}
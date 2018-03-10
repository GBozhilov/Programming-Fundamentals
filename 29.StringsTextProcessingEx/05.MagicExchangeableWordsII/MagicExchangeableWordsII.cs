using System;
using System.Collections.Generic;
using System.Linq;

public class MagicExchangeableWordsII
{
    public static void Main()
    {
        var strings = Console.ReadLine().Split(' ');

        var firstString = strings.First();
        var secondString = strings.Last();
        var shorterLength = Math.Min(firstString.Length, secondString.Length);

        var dict = new Dictionary<char, char>();

        var isExchangeable = true;

        for (int i = 0; i < shorterLength; i++)
        {
            var firstChar = firstString[i];
            var secondChar = secondString[i];

            if (!dict.ContainsKey(firstChar))
            {
                if (!dict.ContainsValue(secondChar))
                {
                    dict.Add(firstChar, secondChar);
                }
                else
                {
                    isExchangeable = false;
                    break;
                }
            }
            else if (dict[firstChar] != secondChar)
            {
                isExchangeable = false;
                break;
            }
        }

        var longerString = firstString.Length > secondString.Length ? firstString : secondString;

        var rest = longerString.Substring(shorterLength);

        foreach (var symbol in rest)
        {
            if (!dict.ContainsValue(symbol) && !dict.ContainsKey(symbol))
            {
                isExchangeable = false;
            }
        }

        Console.WriteLine(isExchangeable.ToString().ToLower());
    }
}

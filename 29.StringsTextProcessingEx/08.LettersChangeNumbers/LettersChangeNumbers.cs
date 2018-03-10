using System;
using System.Linq;

public class LettersChangeNumbers
{
    public static void Main()
    {
        var strings = Console.ReadLine().Split(new char[] { ' ', '\t' },
            StringSplitOptions.RemoveEmptyEntries);

        double sum = 0;

        foreach (var str in strings)
        {
            var leftLetter = str.First();
            var rightLetter = str.Last();
            var number = double.Parse(str.Substring(1, str.Length - 2));

            if (char.IsUpper(leftLetter))
            {
                number /= leftLetter - 'A' + 1;
            }
            else
            {
                number *= leftLetter - 'a' + 1;
            }

            if (char.IsUpper(rightLetter))
            {
                number -= rightLetter - 'A' + 1;
            }
            else
            {
                number += rightLetter - 'a' + 1;
            }

            sum += number;
        }

        Console.WriteLine($"{sum:F2}");
    }
}
using System;
using System.Linq;

class RoundingNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(x => double.Parse(x))
            .ToArray();

        var roundedNums = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            roundedNums[i] = (int)Math.Round(numbers[i],
                MidpointRounding.AwayFromZero);
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"{numbers[i]} => {roundedNums[i]}");
        }
    }
}

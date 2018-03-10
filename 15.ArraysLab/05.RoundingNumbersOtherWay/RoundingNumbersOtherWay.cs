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
            var currentNum = numbers[i];
            var roundedNum = (int)Math.Truncate(Math.Abs(currentNum) + 0.5);

            if (currentNum < 0)
            {
                roundedNum *= -1;
            }

            roundedNums[i] = roundedNum;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"{numbers[i]} => {roundedNums[i]}");
        }
    }
}

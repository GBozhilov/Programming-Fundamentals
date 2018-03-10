using System;
using System.Linq;

class BombNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        var bombInfo = Console.ReadLine().Split(' ');

        var target = int.Parse(bombInfo[0]);
        var radius = int.Parse(bombInfo[1]);

        for (int i = 0; i < numbers.Count; i++)
        {
            var currentNum = numbers[i];

            if (currentNum == target)
            {
                var startIndex = Math.Max(i - radius, 0);
                var endIndex = Math.Min(i + radius, numbers.Count - 1);
                var explosionLength = endIndex - startIndex + 1;

                numbers.RemoveRange(startIndex, explosionLength);

                i = -1;
            }
        }

        Console.WriteLine(numbers.Sum());
    }
}
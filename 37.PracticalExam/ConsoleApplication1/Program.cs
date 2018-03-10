using System;
using System.Linq;

public class PokemonDon_tGo
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ', '\t', '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        long sum = 0;

        while (true)
        {
            if (!numbers.Any())
            {
                break;
            }

            var index = int.Parse(Console.ReadLine());

            if (index < 0)
            {
                var lastElement = numbers.Last();

                numbers.RemoveAt(0);
                numbers.Insert(0, lastElement);
            }

            if (index >= numbers.Count)
            {
                var firstElement = numbers.First();

                numbers.RemoveAt(numbers.Count - 1);
                numbers.Add(firstElement);
            }

            if (index < 0 || index >= numbers.Count)
            {
                continue;
            }

            var oldElement = numbers[index];

            sum += oldElement;
            numbers.RemoveAt(index);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= oldElement)
                {
                    numbers[i] += oldElement;
                }
                else
                {
                    numbers[i] -= oldElement;
                }
            }
        }

        Console.WriteLine(sum);
    }
}
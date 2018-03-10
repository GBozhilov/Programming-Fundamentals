using System;
using System.Linq;

public class Ladybugs
{
    public static void Main()
    {
        var fieldSize = int.Parse(Console.ReadLine());
        var ladybugIndexes = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var field = new int[fieldSize];

        foreach (var index in ladybugIndexes)
        {
            if (index >= 0 && index < fieldSize)
            {
                field[index] = 1;
            }
        }

        while (true)
        {
            var commandLine = Console.ReadLine();

            if (commandLine.Equals("end"))
            {
                break;
            }

            var tokens = commandLine.Split(' ');

            var ladybugIndex = int.Parse(tokens[0]);
            var direction = tokens[1];
            var flyLength = int.Parse(tokens[2]);

            if (ladybugIndex < 0 || ladybugIndex >= field.Length)
            {
                continue;
            }

            if (field[ladybugIndex] == 0)
            {
                continue;
            }

            var position = ladybugIndex;
            field[position] = 0;

            while (true)
            {
                position = direction.Equals("right") ? position + flyLength : position - flyLength;

                if (position < 0 || position >= field.Length)
                {
                    break;
                }

                if (field[position].Equals(1))
                {
                    continue;
                }

                field[position] = 1;
                break;
            }
        }

        Console.WriteLine(string.Join(" ", field));
    }
}
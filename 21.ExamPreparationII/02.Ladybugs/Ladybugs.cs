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

        foreach (var ladybugIndex in ladybugIndexes)
        {
            if (ladybugIndex < 0 || ladybugIndex >= field.Length)
            {
                continue;
            }

            field[ladybugIndex] = 1;
        }

        while (true)
        {
            var commandLine = Console.ReadLine();

            if (commandLine == "end")
            {
                break;
            }

            var commandParams = commandLine.Split(' ');

            var index = int.Parse(commandParams[0]);
            var direction = commandParams[1];
            var flyLength = int.Parse(commandParams[2]);

            if (index < 0 || index >= field.Length)
            {
                continue;
            }

            if (field[index] == 0)
            {
                continue;
            }

            var position = index;
            field[position] = 0;

            while (true)
            {
                position = direction == "right" ? position += flyLength : position -= flyLength;

                if (position < 0 || position >= field.Length)
                {
                    break;
                }

                if (field[position] == 1)
                {
                    continue;
                }
                else
                {
                    field[position] = 1;
                    break;
                }
            }
        }

        Console.WriteLine(string.Join(" ", field));
    }
}
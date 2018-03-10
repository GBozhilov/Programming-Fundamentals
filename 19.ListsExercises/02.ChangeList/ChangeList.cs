using System;
using System.Collections.Generic;
using System.Linq;

public class ChangeList
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var inputLine = Console.ReadLine();

        while (inputLine != "Odd" && inputLine != "Even")
        {
            var tokens = inputLine.Split(' ');
            var command = tokens[0];
            var element = int.Parse(tokens[1]);

            switch (command)
            {
                case "Delete":
                    numbers.RemoveAll(n => n == element);
                    break;
                case "Insert":
                    var index = int.Parse(tokens[2]);
                    numbers.Insert(index, element);
                    break;
            }

            inputLine = Console.ReadLine();
        }

        var evenOrOddParity = inputLine == "Even" ? 0 : 1;

        numbers = numbers
            .Where(n => n % 2 == evenOrOddParity)
            .ToList();

        Console.WriteLine(string.Join(" ", numbers));
    }
}
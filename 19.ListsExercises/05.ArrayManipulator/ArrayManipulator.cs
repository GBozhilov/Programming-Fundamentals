using System;
using System.Collections.Generic;
using System.Linq;

public class ArrayManipulator
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var inputLine = Console.ReadLine();

        while (inputLine != "print")
        {
            var tokens = inputLine.Split(' ');
            var command = tokens[0];

            switch (command)
            {
                case "add":
                    AddElement(numbers, tokens);
                    break;
                case "addMany":
                    AddManyElements(numbers, tokens);
                    break;
                case "contains":
                    ContainsElement(numbers, tokens);
                    break;
                case "remove":
                    RemoveElement(numbers, tokens);
                    break;
                case "shift":
                    ShiftElementsToTheLeft(numbers, tokens);
                    break;
                case "sumPairs":
                    numbers = SumPairs(numbers);
                    break;
            }

            inputLine = Console.ReadLine();
        }

        Console.WriteLine("[" + string.Join(", ", numbers) + "]");
    }

    public static List<int> SumPairs(List<int> numbers)
    {
        List<int> temp = new List<int>();

        for (int i = 0; i < numbers.Count - 1; i += 2)
        {
            var currentNum = numbers[i];
            var nextNum = numbers[i + 1];

            temp.Add(currentNum + nextNum);
        }

        if (numbers.Count % 2 != 0)
        {
            temp.Add(numbers[numbers.Count - 1]);
        }

        return temp;
    }

    public static void ShiftElementsToTheLeft(List<int> numbers, string[] tokens)
    {
        var positions = int.Parse(tokens[1]);

        for (int i = 0; i < positions; i++)
        {
            numbers.Add(numbers[0]);
            numbers.RemoveAt(0);
        }
    }

    public static void RemoveElement(List<int> numbers, string[] tokens)
    {
        var index = int.Parse(tokens[1]);

        numbers.RemoveAt(index);
    }

    public static void ContainsElement(List<int> numbers, string[] tokens)
    {
        var element = int.Parse(tokens[1]);
        var indexOfElement = numbers.IndexOf(element);

        Console.WriteLine(indexOfElement);
    }

    public static void AddManyElements(List<int> numbers, string[] tokens)
    {
        var index = int.Parse(tokens[1]);

        var numsToAdd = tokens
            .Skip(2)
            .Select(int.Parse)
            .ToArray();

        numbers.InsertRange(index, numsToAdd);
    }

    public static void AddElement(List<int> numbers, string[] tokens)
    {
        var index = int.Parse(tokens[1]);
        var element = int.Parse(tokens[2]);

        numbers.Insert(index, element);
    }
}
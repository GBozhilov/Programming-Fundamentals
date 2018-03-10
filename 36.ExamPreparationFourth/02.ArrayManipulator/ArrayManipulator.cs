using System;
using System.Collections.Generic;
using System.Linq;

public class ArrayManipulator
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(n => int.Parse(n))
            .ToArray();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine == "end") break;

            var commandParams = inputLine.Split(' ');
            var command = commandParams[0];

            switch (command)
            {
                case "exchange":
                    var index = int.Parse(commandParams[1]);
                    numbers = ExchangeArrayElements(numbers, index);
                    break;
                case "max":
                case "min":
                    var maxOrMin = command;
                    var evenOrOdd = commandParams[1];
                    FindMaxOrMinEvenOrOddElement(numbers, maxOrMin, evenOrOdd);
                    break;
                case "first":
                case "last":
                    var firstOrLast = command;
                    var count = int.Parse(commandParams[1]);
                    evenOrOdd = commandParams[2];
                    FindFirstOrLastEvenOrOddElement(numbers, firstOrLast, count, evenOrOdd);
                    break;
            }
        }

        Console.WriteLine("[" + string.Join(", ", numbers) + "]");
    }

    public static void FindFirstOrLastEvenOrOddElement(int[] numbers, string firstOrLast, int count, string evenOrOdd)
    {
        if (count > numbers.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        var evenOrOddParity = evenOrOdd == "even" ? 0 : 1;
        var evenOrOddElements = numbers
            .Where(n => n % 2 == evenOrOddParity)
            .ToArray();

        var foundElements = new List<int>();

        if (firstOrLast == "first")
        {
            foundElements = evenOrOddElements
                .Take(count)
                .ToList();
        }
        else
        {
            foundElements = evenOrOddElements
                .Reverse()
                .Take(count)
                .Reverse()
                .ToList();
        }

        Console.WriteLine("[" + string.Join(", ", foundElements) + "]");
    }

    public static void FindMaxOrMinEvenOrOddElement(int[] numbers, string maxOrMin, string evenOrOdd)
    {
        var evenOrOddParity = evenOrOdd == "even" ? 0 : 1;
        var evenOrOddElements = numbers
            .Where(n => n % 2 == evenOrOddParity)
            .ToArray();

        if (!evenOrOddElements.Any())
        {
            Console.WriteLine("No matches");
            return;
        }

        var maxOrMinElement = maxOrMin == "max" ? evenOrOddElements.Max() : evenOrOddElements.Min();
        var mostRightIndex = Array.LastIndexOf(numbers, maxOrMinElement);

        Console.WriteLine(mostRightIndex);
    }

    public static int[] ExchangeArrayElements(int[] numbers, int index)
    {
        var invalidIndex = index < 0 || index >= numbers.Length;

        if (invalidIndex)
        {
            Console.WriteLine("Invalid index");
            return numbers;
        }

        var exchangeIndex = index + 1;

        var leftArr = numbers
            .Take(exchangeIndex)
            .ToArray();
        var rightArr = numbers
            .Skip(exchangeIndex)
            .ToArray();

        var combinedArr = rightArr.Concat(leftArr).ToArray();

        return combinedArr;
    }
}
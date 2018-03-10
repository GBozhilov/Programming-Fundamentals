using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class CommandInterpreter
{
    public static void Main()
    {
        var inputSequance = Regex.Split(Console.ReadLine(), @"\s+").ToList();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine == "end") break;

            var commandParams = Regex.Split(inputLine, @"\s+");
            var command = commandParams[0];
            var length = inputSequance.Count;

            switch (command)
            {
                case "reverse":
                    var areValidParams = CheckParams(commandParams, length);

                    if (areValidParams)
                    {
                        ReverseOrSort(inputSequance, commandParams);
                    }
                    break;
                case "sort":
                    areValidParams = CheckParams(commandParams, length);

                    if (areValidParams)
                    {
                        ReverseOrSort(inputSequance, commandParams);
                    }
                    break;
                case "rollLeft":
                    areValidParams = CheckParams(commandParams, length);

                    if (areValidParams)
                    {
                        RollLeftOrRight(inputSequance, commandParams);
                    }
                    break;
                case "rollRight":
                    areValidParams = CheckParams(commandParams, length);

                    if (areValidParams)
                    {
                        RollLeftOrRight(inputSequance, commandParams);
                    }
                    break;
            }
        }

        Console.WriteLine("[" + string.Join(", ", inputSequance) + "]");
    }

    public static void RollLeftOrRight(List<string> inputSequance, string[] commandParams)
    {
        var command = commandParams[0];
        var count = int.Parse(commandParams[1]);

        count = count % inputSequance.Count;

        if (command == "rollLeft")
        {
            for (int i = 0; i < count; i++)
            {
                var firstElement = inputSequance.First();

                inputSequance.RemoveAt(0);
                inputSequance.Add(firstElement);
            }
        }
        else if (command == "rollRight")
        {
            for (int i = 0; i < count; i++)
            {
                var lastElement = inputSequance.Last();

                inputSequance.RemoveAt(inputSequance.Count - 1);
                inputSequance.Insert(0, lastElement);
            }
        }

    }

    public static void ReverseOrSort(List<string> inputSequance, string[] commandParams)
    {
        var command = commandParams[0];
        var startIndex = int.Parse(commandParams[2]);
        var count = int.Parse(commandParams[4]);

        List<string> range = inputSequance.GetRange(startIndex, count);

        if (command == "reverse")
        {
            range.Reverse();
        }
        else if (command == "sort")
        {
            range.Sort();
        }

        inputSequance.RemoveRange(startIndex, count);
        inputSequance.InsertRange(startIndex, range);
    }

    public static bool CheckParams(string[] commandParams, int length)
    {
        var areValidParams = true;

        if (commandParams.Length == 5)
        {
            var startIndex = int.Parse(commandParams[2]);
            var count = int.Parse(commandParams[4]);

            if ((startIndex < 0 || startIndex >= length) 
                || (count < 0 || count + startIndex > length))
            {
                Console.WriteLine("Invalid input parameters.");
                areValidParams = false;
            }
        }
        else //if (commandParams.Length == 3)
        {
            var count = int.Parse(commandParams[1]);

            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                areValidParams = false;
            }
        }

        return areValidParams;
    }
}
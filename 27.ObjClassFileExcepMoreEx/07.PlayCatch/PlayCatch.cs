using System;
using System.Linq;

public class PlayCatch
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        var exceptionsCount = 0;

        while (exceptionsCount < 3)
        {
            var tokens = Console.ReadLine().Split(' ');
            var command = tokens[0];

            try
            {
                if (command == "Replace")
                {
                    var index = int.Parse(tokens[1]);
                    var element = int.Parse(tokens[2]);

                    numbers[index] = element;
                }
                else if (command == "Print")
                {
                    var start = int.Parse(tokens[1]);
                    var end = int.Parse(tokens[2]);

                    var range = numbers.GetRange(start, end - start + 1);

                    Console.WriteLine(string.Join(", ", range));
                }
                else if (command == "Show")
                {
                    var index = int.Parse(tokens[1]);

                    Console.WriteLine(numbers[index]);
                }
            }
            catch (Exception)
            {
                var check = 0;
                var firstParam = tokens[1];

                if (tokens.Length > 2)
                {
                    var secondParam = tokens[2];

                    if (int.TryParse(firstParam, out check) && int.TryParse(secondParam, out check))
                    {
                        Console.WriteLine("The index does not exist!");
                    }
                    else
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                    }
                }
                else
                {
                    if (int.TryParse(firstParam, out check))
                    {
                        Console.WriteLine("The index does not exist!");
                    }
                    else
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                    }
                }

                exceptionsCount++;
            }
        }

        Console.WriteLine(string.Join(", ", numbers));
    }
}
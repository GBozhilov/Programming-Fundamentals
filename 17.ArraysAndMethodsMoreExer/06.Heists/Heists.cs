using System;
using System.Linq;

public class Heists
{
    public static void Main()
    {
        var prices = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var totatLoot = 0;
        var totatExpenses = 0;
        var jewelsPrice = prices[0];
        var goldPrice = prices[1];

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine == "Jail Time")
            {
                break;
            }

            var tokens = inputLine.Split(' ');

            var loot = tokens[0];
            var expenses = int.Parse(tokens.Last());

            foreach (var symbol in loot)
            {
                if (symbol == '%')
                {
                    totatLoot += jewelsPrice;
                }
                else if (symbol == '$')
                {
                    totatLoot += goldPrice;
                }
            }

            totatExpenses += expenses;
        }

        var difference = totatLoot - totatExpenses;

        if (difference >= 0)
        {
            Console.WriteLine($"Heists will continue. Total earnings: {difference}.");
        }
        else
        {
            Console.WriteLine($"Have to find another job. Lost: {Math.Abs(difference)}.");
        }
    }
}
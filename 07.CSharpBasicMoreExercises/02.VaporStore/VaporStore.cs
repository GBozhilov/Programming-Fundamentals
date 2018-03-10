using System;

public class VaporStore
{
    public static void Main()
    {
        var startBalance = double.Parse(Console.ReadLine());

        var balance = startBalance;

        while (true)
        {
            var game = Console.ReadLine();

            if (game == "Game Time")
            {
                break;
            }

            var currentPrice = 0.0;

            switch (game)
            {
                case "OutFall 4":
                    currentPrice = 39.99;
                    break;
                case "CS: OG":
                    currentPrice = 15.99;
                    break;
                case "Zplinter Zell":
                    currentPrice = 19.99;
                    break;
                case "Honored 2":
                    currentPrice = 59.99;
                    break;
                case "RoverWatch":
                    currentPrice = 29.99;
                    break;
                case "RoverWatch Origins Edition":
                    currentPrice = 39.99;
                    break;
                default:
                    Console.WriteLine("Not Found");
                    continue;
            }

            if (balance >= currentPrice)
            {
                Console.WriteLine($"Bought {game}");
                balance -= currentPrice;
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }

            if (balance <= 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
        }

        Console.WriteLine($"Total spent: ${startBalance - balance:F2}. Remaining: ${balance:F2}");
    }
}
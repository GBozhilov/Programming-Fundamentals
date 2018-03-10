using System;
using System.Linq;
using System.Text.RegularExpressions;

public class WinningTicket
{
    public static void Main()
    {
        var tickets = Console.ReadLine()
            .Split(',')
            .Select(t => t.Trim())
            .ToArray();

        const string pattern = @"([@#$^])\1{5,9}";
        var regex = new Regex(pattern);

        foreach (var ticket in tickets)
        {
            if (ticket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
                continue;
            }

            var leftHalf = ticket.Substring(0, 10);
            var rightHalf = ticket.Substring(10);

            var leftMatch = regex.Match(leftHalf);
            var rightMatch = regex.Match(rightHalf);

            if (leftMatch.Success && rightMatch.Success)
            {
                var winLength = Math.Min(leftMatch.Length, rightMatch.Length);
                var winSymbol = leftMatch.Value[0];
                var hasJackpot = winLength == 10;

                Console.Write($"ticket \"{ticket}\" - {winLength}{winSymbol}");
                Console.WriteLine(hasJackpot ? " Jackpot!" : string.Empty);
            }
            else
            {
                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
        }
    }
}
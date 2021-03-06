﻿using System;
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

        foreach (var ticket in tickets)
        {
            if (ticket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
                continue;
            }

            var pattern = @"(?<winSymbol>[@#$^])\1{5,9}";

            var leftHalf = ticket.Substring(0, 10);
            var rightHalf = ticket.Substring(10);

            var leftMatch = Regex.Match(leftHalf, pattern);
            var rightMatch = Regex.Match(rightHalf, pattern);

            var leftWinSymbol = leftMatch.Groups["winSymbol"].Value;
            var rightWinSymbol = rightMatch.Groups["winSymbol"].Value;

            if ((leftMatch.Success && rightMatch.Success) && (leftWinSymbol == rightWinSymbol))
            {
                var winLength = Math.Min(leftMatch.Length, rightMatch.Length);
                var hasJackpot = winLength == 10;
                var winSymbol = leftWinSymbol = rightWinSymbol;

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
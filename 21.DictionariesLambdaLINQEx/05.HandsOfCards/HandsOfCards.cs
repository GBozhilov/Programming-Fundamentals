using System;
using System.Collections.Generic;
using System.Linq;

public class HandsOfCards
{
    public static void Main()
    {
        var playerCards = new Dictionary<string, List<string>>();

        var inputLine = Console.ReadLine();

        while (inputLine != "JOKER")
        {
            var inputParams = inputLine.Split(':');

            var player = inputParams[0];
            var cards = inputParams[1]
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToArray();

            if (!playerCards.ContainsKey(player))
            {
                playerCards.Add(player, new List<string>());
            }

            playerCards[player].AddRange(cards);

            inputLine = Console.ReadLine();
        }

        CalculatePrintPlayerScore(playerCards);
    }

    public static void CalculatePrintPlayerScore(Dictionary<string, List<string>> playerCards)
    {
        foreach (var playerCardsPair in playerCards)
        {
            var player = playerCardsPair.Key;
            var cards = playerCardsPair.Value;

            var playerScore = 0;

            foreach (var card in cards)
            {
                var rank = card.Substring(0, card.Length - 1);
                var type = card.Substring(card.Length - 1);

                var rankValue = GetRankValue(rank);
                var typeValue = GetTypeValue(type);
                var cardScore = rankValue * typeValue;

                playerScore += cardScore;
            }

            Console.WriteLine($"{player}: {playerScore}");
        }
    }

    public static int GetTypeValue(string type)
    {
        switch (type)
        {
            case "C":
                return 1;
            case "D":
                return 2;
            case "H":
                return 3;
            case "S":
                return 4;
            default:
                return 0;
        }
    }

    public static int GetRankValue(string rank)
    {
        switch (rank)
        {
            case "2":
                return 2;
            case "3":
                return 3;
            case "4":
                return 4;
            case "5":
                return 5;
            case "6":
                return 6;
            case "7":
                return 7;
            case "8":
                return 8;
            case "9":
                return 9;
            case "10":
                return 10;
            case "J":
                return 11;
            case "Q":
                return 12;
            case "K":
                return 13;
            case "A":
                return 14;
            default:
                return 0;
        }
    }
}
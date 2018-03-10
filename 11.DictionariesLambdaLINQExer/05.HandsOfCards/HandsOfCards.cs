using System;
using System.Collections.Generic;
using System.Linq;

public class HandsOfCards
{
    public static void Main()
    {
        string inputLine = Console.ReadLine();

        Dictionary<string, List<string>> playerCards = new Dictionary<string, List<string>>();

        while (inputLine != "JOKER")
        {
            string[] inputParams = inputLine.Split(':');

            string name = inputParams[0];
            string[] cards = inputParams[1]
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                //.Select(c => c.Trim())
                .ToArray();

            if (!playerCards.ContainsKey(name))
                playerCards.Add(name, new List<string>());

            playerCards[name].AddRange(cards);

            inputLine = Console.ReadLine();
        }

        CalculatePrintPlayerScore(playerCards);
    }

    static void CalculatePrintPlayerScore(Dictionary<string, List<string>> playerCards)
    {
        foreach (KeyValuePair<string, List<string>> KVP in playerCards)
        {
            string playerName = KVP.Key;
            List<string> cards = KVP.Value;

            int playerScore = 0;

            foreach (string card in cards)
            {
                string rank = card.Substring(0, card.Length - 1);
                string type = card.Substring(card.Length - 1);

                int rankValue = GetRankValue(rank);
                int typeValue = GetTypeValue(type);

                playerScore += rankValue * typeValue;
            }

            Console.WriteLine($"{playerName}: {playerScore}");
        }
    }

    static int GetTypeValue(string type)
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

    static int GetRankValue(string rank)
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class СръбскоUnleashed
{
    public static void Main()
    {
        var dictionary = new Dictionary<string, Dictionary<string, long>>();
        var pattern = @"(.*?) @(.*?) (\d+) (\d+)";

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine.Equals("End"))
            {
                break;
            }

            if (!Regex.IsMatch(inputLine, pattern))
            {
                continue;
            }

            var tokens = inputLine.Split(new char[] { '@' },
                StringSplitOptions.RemoveEmptyEntries);

            var singer = tokens[0].Trim();
            var concertInfo = tokens[1].Trim().Split(' ');
            var ticketPrice = int.Parse(concertInfo[concertInfo.Length - 2]);
            var ticketCount = int.Parse(concertInfo[concertInfo.Length - 1]);
            var profit = (long)ticketCount * ticketPrice;

            var venue = string.Empty;

            for (int i = 0; i < concertInfo.Length - 2; i++)
            {
                venue += " " + concertInfo[i];
            }

            venue = venue.Trim();

            if (!dictionary.ContainsKey(venue))
            {
                dictionary[venue] = new Dictionary<string, long>();
            }

            if (!dictionary[venue].ContainsKey(singer))
            {
                dictionary[venue][singer] = 0;
            }

            dictionary[venue][singer] += profit;
        }

        PrintResult(dictionary);
    }

    public static void PrintResult(Dictionary<string, Dictionary<string, long>> dictionary)
    {
        foreach (var venueEntry in dictionary)
        {
            var venue = venueEntry.Key;
            var singersProfits = venueEntry.Value;

            Console.WriteLine(venue);

            foreach (var singerProfitPair in singersProfits.OrderByDescending(kvp => kvp.Value))
            {
                var singer = singerProfitPair.Key;
                var profit = singerProfitPair.Value;

                Console.WriteLine($"#  {singer} -> {profit}");
            }
        }
    }
}
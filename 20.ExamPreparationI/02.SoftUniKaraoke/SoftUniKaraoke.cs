using System;
using System.Collections.Generic;
using System.Linq;

public class SoftUniKaraoke
{
    public static void Main()
    {
        var participantAwards = new Dictionary<string, SortedSet<string>>();

        var appliedParticipants = Console.ReadLine()
            .Split(',')
            .Select(p => p.Trim())
            .ToArray();

        var availableSongs = Console.ReadLine()
            .Split(',')
            .Select(s => s.Trim())
            .ToArray();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine == "dawn")
            {
                break;
            }

            var performanceParams = inputLine
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();

            var participant = performanceParams[0];
            var song = performanceParams[1];
            var award = performanceParams[2];

            if (!appliedParticipants.Contains(participant) || !availableSongs.Contains(song))
            {
                continue;
            }

            if (!participantAwards.ContainsKey(participant))
            {
                participantAwards[participant] = new SortedSet<string>();
            }

            participantAwards[participant].Add(award);
        }

        if (!participantAwards.Any())
        {
            Console.WriteLine("No awards");
            return;
        }

        participantAwards = participantAwards
            .OrderByDescending(a => a.Value.Count)
            .ThenBy(p => p.Key)
            .ToDictionary(p => p.Key, a => a.Value);

        foreach (var KVP in participantAwards)
        {
            var participant = KVP.Key;
            var uniqueAwards = KVP.Value;
            var awardsCount = uniqueAwards.Count;

            Console.WriteLine($"{participant}: {awardsCount} awards");

            foreach (var award in uniqueAwards)
            {
                Console.WriteLine($"--{award}");
            }
        }
    }
}
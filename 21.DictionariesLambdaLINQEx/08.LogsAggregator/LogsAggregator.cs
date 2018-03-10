using System;
using System.Collections.Generic;
using System.Linq;

public class LogsAggregator
{
    public static void Main()
    {
        var usersData = new SortedDictionary<string, SortedDictionary<string, int>>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split(' ');

            var IP = tokens[0];
            var username = tokens[1];
            var duration = int.Parse(tokens[2]);

            if (!usersData.ContainsKey(username))
            {
                usersData[username] = new SortedDictionary<string, int>();
            }

            if (!usersData[username].ContainsKey(IP))
            {
                usersData[username][IP] = 0;
            }

            usersData[username][IP] += duration;
        }

        PrintResult(usersData);
    }

    public static void PrintResult(SortedDictionary<string, SortedDictionary<string, int>> usersData)
    {
        foreach (var KVP in usersData)
        {
            var username = KVP.Key;
            var IPDuration = KVP.Value;
            var totalDuration = IPDuration.Values.Sum();
            var userIPList = IPDuration.Keys.ToList();

            Console.WriteLine($"{username}: {totalDuration} [{string.Join(", ", userIPList)}]");
        }
    }
}
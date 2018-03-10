using System;
using System.Collections.Generic;
using System.Linq;

public class LogsAggregator
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        SortedDictionary<string, SortedDictionary<string, int>> usersData =
            new SortedDictionary<string, SortedDictionary<string, int>>();

        for (int i = 0; i < n; i++)
        {
            string[] inputParams = Console.ReadLine().Split(' ');

            string IP = inputParams[0];
            string username = inputParams[1];
            int duration = int.Parse(inputParams[2]);

            if (!usersData.ContainsKey(username))
                usersData[username] = new SortedDictionary<string, int>();

            if (!usersData[username].ContainsKey(IP))
                usersData[username][IP] = 0;

            usersData[username][IP] += duration;
        }

        foreach (KeyValuePair<string, SortedDictionary<string, int>> user in usersData)
        {
            string username = user.Key;
            SortedDictionary<string, int> IPDuration = user.Value;
            int totalDuration = IPDuration.Values.Sum();
            List<string> userIPs = IPDuration.Keys.ToList();

            Console.WriteLine($"{username}: {totalDuration} [{string.Join(", ", userIPs)}]");
        }
    }
}
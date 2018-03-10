using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class EmailStatistics
{
    public static void Main()
    {
        var usersByDomain = new Dictionary<string, HashSet<string>>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var currentEmail = Console.ReadLine();

            var pattern = @"^(?<username>[A-Za-z]{5,})@(?<domain>[a-z]{3,}\.(?:com|bg|org))$";
            var match = Regex.Match(currentEmail, pattern);

            if (!match.Success) continue;

            var domain = match.Groups["domain"].Value;
            var username = match.Groups["username"].Value;

            if (!usersByDomain.ContainsKey(domain))
            {
                usersByDomain[domain] = new HashSet<string>();
            }

            usersByDomain[domain].Add(username);
        }

        usersByDomain = usersByDomain
            .OrderByDescending(x => x.Value.Count)
            .ToDictionary(x => x.Key, y => y.Value);

        foreach (var domainUsersPair in usersByDomain)
        {
            var domain = domainUsersPair.Key;
            var usernames = domainUsersPair.Value;

            Console.WriteLine($"{domain}:");

            foreach (var user in usernames)
            {
                Console.WriteLine($"### {user}");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class FootballLeague
{
    public static void Main()
    {
        var key = Regex.Escape(Console.ReadLine());

        var pattern = $@"^.*(?:{key})(?<team1>[A-Za-z]*)(?:{key}).*(?:{key})(?<team2>[A-Za-z]*)(?:{key}).* (?<team1Score>\d+):(?<team2Score>\d+)$";

        var teamScores = new Dictionary<string, Score>();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine == "final")
            {
                break;
            }

            var match = Regex.Match(inputLine, pattern);

            if (!match.Success)
            {
                continue;
            }

            var firstTeam = new string(match.Groups["team1"].Value
                .ToUpper()
                .Reverse()
                .ToArray());
            var secondTeam = new string(match.Groups["team2"].Value
                .ToUpper()
                .Reverse()
                .ToArray());

            var firstScore = int.Parse(match.Groups["team1Score"].Value);
            var secondScore = int.Parse(match.Groups["team2Score"].Value);

            var firstTeamPoints = 0;
            var secondTeamPoints = 0;

            if (firstScore > secondScore)
            {
                firstTeamPoints = 3;
            }
            else if (secondScore > firstScore)
            {
                secondTeamPoints = 3;
            }
            else
            {
                firstTeamPoints = 1;
                secondTeamPoints = 1;
            }

            if (!teamScores.ContainsKey(firstTeam))
            {
                teamScores[firstTeam] = new Score();
            }

            if (!teamScores.ContainsKey(secondTeam))
            {
                teamScores[secondTeam] = new Score();
            }

            teamScores[firstTeam].Points += firstTeamPoints;
            teamScores[secondTeam].Points += secondTeamPoints;
            teamScores[firstTeam].Goals += firstScore;
            teamScores[secondTeam].Goals += secondScore;
        }

        var leagueStandings = teamScores
            .OrderByDescending(x => x.Value.Points)
            .ThenBy(x => x.Key)
            .ToDictionary(x => x.Key, y => y.Value);

        var place = 1;

        Console.WriteLine("League standings:");

        foreach (var teamScorePair in leagueStandings)
        {
            var team = teamScorePair.Key;
            var points = teamScorePair.Value.Points;

            Console.WriteLine($"{place}. {team} {points}");

            place++;
        }

        Console.WriteLine("Top 3 scored goals:");

        teamScores
            .OrderByDescending(t => t.Value.Goals)
            .ThenBy(t => t.Key)
            .Take(3).Select(t => $"- {t.Key} -> {t.Value.Goals}")
            .ToList()
            .ForEach(a => Console.WriteLine(a));
    }

    public class Score
    {
        public int Points { get; set; }

        public int Goals { get; set; }
    }
}
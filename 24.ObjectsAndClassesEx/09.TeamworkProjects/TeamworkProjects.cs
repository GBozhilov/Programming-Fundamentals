using System;
using System.Collections.Generic;
using System.Linq;

public class TeamworkProjects
{
    public static void Main()
    {
        var teams = new List<Team>();

        RegisteringTeams(teams);
        AddingMembers(teams);
        PrintingResults(teams);
    }

    public static void RegisteringTeams(List<Team> teams)
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var teamParams = Console.ReadLine().Split('-');

            var creatorName = teamParams[0];
            var teamName = teamParams[1];

            var newTeam = new Team()
            {
                Name = teamName,
                Members = new List<string>(),
                Creator = creatorName
            };

            if (teams.Any(t => t.Name == teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
                continue;
            }

            if (teams.Any(t => t.Creator == creatorName))
            {
                Console.WriteLine($"{creatorName} cannot create another team!");
                continue;
            }

            teams.Add(newTeam);

            Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
        }
    }

    public static void AddingMembers(List<Team> teams)
    {
        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine.Equals("end of assignment"))
            {
                break;
            }

            var tokens = inputLine.Split(new char[] { '-', '>' });

            var user = tokens[0];
            var teamJoin = tokens[2];

            if (!teams.Any(t => t.Name == teamJoin))
            {
                Console.WriteLine($"Team {teamJoin} does not exist!");
                continue;
            }

            if (teams.Any(t => t.Creator == user) || teams.Any(t => t.Members.Contains(user)))
            {
                Console.WriteLine($"Member {user} cannot join team {teamJoin}!");
                continue;
            }

            var existingTeam = teams.First(t => t.Name == teamJoin);

            existingTeam.Members.Add(user);
        }
    }

    public static void PrintingResults(List<Team> teams)
    {
        teams = teams
            .OrderByDescending(t => t.Members.Count)
            .ThenBy(t => t.Name)
            .ToList();

        foreach (var team in teams)
        {
            if (team.Members.Count == 0) continue;

            Console.WriteLine(team.Name);
            Console.WriteLine($"- {team.Creator}");

            var members = team.Members
                .OrderBy(m => m)
                .ToList();

            foreach (var member in members)
            {
                Console.WriteLine($"-- {member}");
            }
        }

        var disbandTeams = teams
            .Where(t => t.Members.Count == 0)
            .Select(t => t.Name)
            .OrderBy(x => x)
            .ToList();

        Console.WriteLine("Teams to disband:");

        foreach (var teamName in disbandTeams)
        {
            Console.WriteLine(teamName);
        }
    }
}

public class Team
{
    public string Name { get; set; }

    public List<string> Members { get; set; }

    public string Creator { get; set; }
}
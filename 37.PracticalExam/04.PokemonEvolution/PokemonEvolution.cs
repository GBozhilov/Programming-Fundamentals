using System;
using System.Collections.Generic;
using System.Linq;

public class PokemonEvolution
{
    public static void Main()
    {
        var nameEvolutions = new Dictionary<string, List<Evolution>>();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine == "wubbalubbadubdub")
            {
                break;
            }

            var tokens = inputLine
                .Split(new char[] { ' ', '-', '>' },
                    StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length > 1)
            {
                var name = tokens[0];
                var type = tokens[1];
                var index = long.Parse(tokens[2]);

                var newEvolution = new Evolution()
                {
                    Type = type,
                    Index = index
                };

                if (!nameEvolutions.ContainsKey(name))
                {
                    nameEvolutions[name] = new List<Evolution>();
                }

                nameEvolutions[name].Add(newEvolution);
            }
            else
            {
                var inputName = tokens[0];

                if (nameEvolutions.ContainsKey(inputName))
                {
                    var evolutions = nameEvolutions[inputName];

                    Console.WriteLine($"# {inputName}");

                    foreach (var evolution in evolutions)
                    {
                        var type = evolution.Type;
                        var index = evolution.Index;

                        Console.WriteLine($"{type} <-> {index}");
                    }
                }
            }
        }

        foreach (var nameEvoPair in nameEvolutions)
        {
            var name = nameEvoPair.Key;
            var evolutions = nameEvoPair.Value
                .OrderByDescending(e => e.Index);

            Console.WriteLine($"# {name}");

            foreach (var evolution in evolutions)
            {
                var type = evolution.Type;
                var index = evolution.Index;

                Console.WriteLine($"{type} <-> {index}");
            }
        }
    }
}

public class Evolution
{
    public string Type { get; set; }

    public long Index { get; set; }
}
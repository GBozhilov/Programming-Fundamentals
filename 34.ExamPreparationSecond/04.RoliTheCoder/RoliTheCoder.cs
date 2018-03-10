using System;
using System.Collections.Generic;
using System.Linq;

public class Event
{
    public string Name { get; set; }

    public List<string> Participants { get; set; }
}

public class RoliTheCoder
{
    public static void Main()
    {
        var eventsById = new Dictionary<string, Event>();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine == "Time for Code")
            {
                break;
            }

            var tokens = inputLine.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            var id = tokens[0];
            var eventName = tokens[1];
            var participants = tokens
                .Skip(2)
                .ToArray();

            if (!eventName.StartsWith("#"))
            {
                continue;
            }

            eventName = eventName.TrimStart('#');

            var newEvent = new Event()
            {
                Name = eventName,
                Participants = new List<string>(participants)
            };

            if (eventsById.ContainsKey(id))
            {
                if (eventsById[id].Name != eventName)
                {
                    continue;
                }

                eventsById[id].Participants.AddRange(participants);
            }

            if (!eventsById.ContainsKey(id))
            {
                eventsById[id] = newEvent;
            }
        }

        eventsById = eventsById
            .OrderByDescending(x => x.Value.Participants.Distinct().Count())
            .ThenBy(x => x.Value.Name)
            .ToDictionary(x => x.Key, y => y.Value);

        PrintResult(eventsById);
    }

    public static void PrintResult(Dictionary<string, Event> eventsById)
    {
        foreach (var @event in eventsById.Values)
        {
            var eventName = @event.Name;
            var participants = @event.Participants
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine($"{eventName} - {participants.Count}");

            foreach (var participant in participants)
            {
                Console.WriteLine(participant);
            }
        }
    }
}
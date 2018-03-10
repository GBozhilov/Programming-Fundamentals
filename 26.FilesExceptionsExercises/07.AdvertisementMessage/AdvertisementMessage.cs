using System;
using System.IO;
using System.Text;

public class AdvertisementMessage
{
    public static void Main()
    {
        var numberOfMessages = int.Parse(Console.ReadLine());

        var phrases = File.ReadAllLines("InputFolder/phrases.txt");
        var events = File.ReadAllLines("InputFolder/events.txt");
        var authors = File.ReadAllLines("InputFolder/authors.txt");
        var towns = File.ReadAllLines("InputFolder/towns.txt");

        var randomGen = new Random();
        var output = new StringBuilder();

        for (int i = 0; i < numberOfMessages; i++)
        {
            var phraseIndex = randomGen.Next(0, phrases.Length);
            var eventIndex = randomGen.Next(0, events.Length);
            var authorIndex = randomGen.Next(0, authors.Length);
            var townIndex = randomGen.Next(0, towns.Length);

            var phrase = phrases[phraseIndex];
            var @event = events[eventIndex];
            var author = authors[authorIndex];
            var town = towns[townIndex];

            output.AppendLine($"{phrase} {@event} {author} – {town}.");
        }

        File.WriteAllText("output.txt", output.ToString());
    }
}
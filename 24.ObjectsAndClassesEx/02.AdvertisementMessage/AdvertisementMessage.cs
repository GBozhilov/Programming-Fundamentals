using System;

public class AdvertisementMessage
{
    public static void Main()
    {
        var numberOfMessages = int.Parse(Console.ReadLine());

        var phrases = new string[]
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
        };

        var events = new string[]
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };

        var authors = new string[]
        {
            "Diana",
            "Petya",
            "Stella",
            "Elena",
            "Katya",
            "Iva",
            "Annie",
            "Eva"
        };

        var towns = new string[]
        {
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse"
        };

        var randomGen = new Random();

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

            Console.WriteLine($"{phrase} {@event} {author} – {town}.");
        }
    }
}
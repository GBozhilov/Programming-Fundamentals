using System;
using System.Linq;

public class ShortWordsSorted
{
    public static void Main()
    {
        var separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

        var words = Console.ReadLine()
            .ToLower()
            .Split(separators,
                StringSplitOptions.RemoveEmptyEntries);

        var resultWords = words
            .Distinct()
            .Where(w => w.Length < 5)
            .OrderBy(w => w)
            .ToArray();

        Console.WriteLine(string.Join(", ", resultWords));
    }
}
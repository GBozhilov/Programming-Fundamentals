using System;

public class CountSubstringOccurrences
{
    public static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string pattern = Console.ReadLine().ToLower();

        int occurrences = 0;
        int index = text.IndexOf(pattern);

        while (index != -1)
        {
            occurrences++;
            index = text.IndexOf(pattern, index + 1);
        }

        Console.WriteLine(occurrences);
    }
}
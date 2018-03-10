using System;
using System.Text.RegularExpressions;

public class MelrahShake
{
    public static void Main()
    {
        string inputLine = Console.ReadLine();
        string key = Console.ReadLine();

        string result = inputLine;

        while (true)
        {
            Regex regex = new Regex(Regex.Escape(key));
            MatchCollection matches = regex.Matches(inputLine);

            if (matches.Count < 2 || key.Length == 0)
            {
                Console.WriteLine("No shake.");
                break;
            }

            int leftIndex = result.IndexOf(key);
            int rightIndex = result.LastIndexOf(key);

            result = result.Remove(rightIndex, key.Length);
            result = result.Remove(leftIndex, key.Length);

            int removalIndex = key.Length / 2;
            key = key.Remove(removalIndex, 1);

            Console.WriteLine("Shaked it.");
        }

        Console.WriteLine(result);
    }
}
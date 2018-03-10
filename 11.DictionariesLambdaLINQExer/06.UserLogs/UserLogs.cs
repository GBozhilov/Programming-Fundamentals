using System;
using System.Collections.Generic;
using System.Linq;

public class UserLogs
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();

        var dictionary = new SortedDictionary<string, Dictionary<string, int>>();

        while (!inputLine.Equals("end"))
        {
            var logParams = inputLine.Split(new char[] { 'I', 'P', '=', ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            var IP = logParams[0];
            var username = logParams[4];

            if (!dictionary.ContainsKey(username))
                dictionary[username] = new Dictionary<string, int>();

            if (!dictionary[username].ContainsKey(IP))
                dictionary[username][IP] = 0;

            dictionary[username][IP]++;

            inputLine = Console.ReadLine();
        }

        PrintResult(dictionary);
    }

    static void PrintResult(SortedDictionary<string, Dictionary<string, int>> dictionary)
    {
        foreach (var KVP in dictionary)
        {
            var username = KVP.Key;
            var IPcount = KVP.Value;

            Console.WriteLine($"{username}: ");

            var temp = 0;

            foreach (var entry in IPcount)
            {
                var IP = entry.Key;
                var count = entry.Value;

                var isLastIP = temp == IPcount.Count - 1;

                Console.Write(!isLastIP ? $"{IP} => {count}, " : $"{IP} => {count}.");
                temp++;
            }

            Console.WriteLine();
        }
    }
}
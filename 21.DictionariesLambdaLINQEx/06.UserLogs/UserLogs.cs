using System;
using System.Collections.Generic;

public class UserLogs
{
    public static void Main()
    {
        var users = new SortedDictionary<string, Dictionary<string, int>>();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine.Equals("end"))
            {
                break;
            }

            var logParams = inputLine.Split(new char[] { 'I', 'P', '=', ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            var IP = logParams[0];
            var username = logParams[4];

            if (!users.ContainsKey(username))
            {
                users[username] = new Dictionary<string, int>();
            }

            if (!users[username].ContainsKey(IP))
            {
                users[username][IP] = 0;
            }

            users[username][IP]++;
        }

        PrintDictionary(users);
    }

    public static void PrintDictionary(SortedDictionary<string, Dictionary<string, int>> users)
    {
        foreach (var KVP in users)
        {
            var username = KVP.Key;
            var IPCount = KVP.Value;

            Console.WriteLine($"{username}:");

            var isFirstPrint = true;

            foreach (var entry in IPCount)
            {
                var IP = entry.Key;
                var messagesCount = entry.Value;

                Console.Write(isFirstPrint ? $"{IP} => {messagesCount}" : $", {IP} => {messagesCount}");

                isFirstPrint = false;
            }

            Console.WriteLine(".");
        }
    }
}
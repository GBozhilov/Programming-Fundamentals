using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class QueryMess
{
    public static void Main()
    {
        var pattern = @"([^&=?]*)=([^&=]*)";
        var innerPattern = @"(%20|\+)+";

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine.Equals("END"))
            {
                break;
            }

            var matches = Regex.Matches(inputLine, pattern);
            var resultDict = new Dictionary<string, List<string>>();

            for (int i = 0; i < matches.Count; i++)
            {
                var field = matches[i].Groups[1].Value;
                var value = matches[i].Groups[2].Value;

                field = Regex.Replace(field, innerPattern, " ").Trim();
                value = Regex.Replace(value, innerPattern, " ").Trim();

                if (!resultDict.ContainsKey(field))
                {
                    resultDict[field] = new List<string>();
                }

                resultDict[field].Add(value);
            }

            foreach (var fieldValuePair in resultDict)
            {
                var field = fieldValuePair.Key;
                var values = fieldValuePair.Value;
                var valuesStr = "[" + string.Join(", ", values) + "]";

                Console.Write($"{field}={valuesStr}");
            }

            Console.WriteLine();
        }
    }
}
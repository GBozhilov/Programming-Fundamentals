using System;

public class SentenceTheThief
{
    public static void Main()
    {
        var type = Console.ReadLine();
        var n = int.Parse(Console.ReadLine());

        var thiefID = long.MinValue;
        double years = 0;

        for (int i = 0; i < n; i++)
        {
            var currentID = long.Parse(Console.ReadLine());

            thiefID = GetThiefID(type, thiefID, currentID);

            years = thiefID > 0 ? thiefID / 127.0 : thiefID / -128.0;
        }

        Console.Write($"Prisoner with id {thiefID} is sentenced to {Math.Ceiling(years)} year");
        Console.WriteLine(years > 1 ? "s" : string.Empty);
    }

    public static long GetThiefID(string numeralType, long thiefID, long currentID)
    {
        var isSbyteValue = currentID >= sbyte.MinValue && currentID <= sbyte.MaxValue;
        var isIntValue = currentID >= int.MinValue && currentID <= int.MaxValue;
        var isLongValue = currentID >= long.MinValue && currentID <= long.MaxValue;

        if (numeralType == "sbyte" && isSbyteValue)
        {
            thiefID = Math.Max(thiefID, currentID);
        }
        else if (numeralType == "int" && isIntValue)
        {
            thiefID = Math.Max(thiefID, currentID);
        }
        else if (numeralType == "long" && isLongValue)
        {
            thiefID = Math.Max(thiefID, currentID);
        }

        return thiefID;
    }
}
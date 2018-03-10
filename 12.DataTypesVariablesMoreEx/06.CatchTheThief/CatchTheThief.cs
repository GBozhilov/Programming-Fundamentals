using System;

public class CatchTheThief
{
    public static void Main()
    {
        var numeralType = Console.ReadLine();
        var n = int.Parse(Console.ReadLine());

        var thiefID = long.MinValue;

        for (int i = 0; i < n; i++)
        {
            var currentID = long.Parse(Console.ReadLine());

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
        }

        Console.WriteLine(thiefID);
    }
}
using System;

public class BooleanVariable
{
    public static void Main()
    {
        string booleanStr = Console.ReadLine();

        bool isTrue = Convert.ToBoolean(booleanStr);

        Console.WriteLine(isTrue ? "Yes" : "No");
    }
}
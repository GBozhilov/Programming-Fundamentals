using System;

public class GreaterOfTwoValues
{
    public static void Main()
    {
        var type = Console.ReadLine();

        switch (type)
        {
            case "int":
                var firstNum = int.Parse(Console.ReadLine());
                var secondNum = int.Parse(Console.ReadLine());
                var greaterNum = GetMax(firstNum, secondNum);
                Console.WriteLine(greaterNum);
                break;
            case "char":
                var firstChar = Console.ReadLine()[0];
                var secondChar = Console.ReadLine()[0];
                var greaterChar = (char)(GetMax(firstChar, secondChar));
                Console.WriteLine(greaterChar);
                break;
            case "string":
                var firstStr = Console.ReadLine();
                var secondStr = Console.ReadLine();
                var greaterStr = GetMax(firstStr, secondStr);
                Console.WriteLine(greaterStr);
                break;
        }
    }

    public static string GetMax(string firstStr, string secondStr)
    {
        //string.Compare(firstStr, secondStr) > 0
        //string.CompareOrdinal(firstStr, secondStr) > 0
        if (firstStr.CompareTo(secondStr) > 0)
        {
            return firstStr;
        }

        return secondStr;
    }

    public static int GetMax(int firstNum, int secondNum)
    {
        return Math.Max(firstNum, secondNum);
    }
}